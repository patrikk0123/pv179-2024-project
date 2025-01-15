class Storage {
    cart = [];
    
    constructor() {
        this._loadCart()
    }
    
    getCart() {
        return this.cart;
    }
    
    addCartItem(item) {
        let index = this.cart.findIndex((i) => i.id === item.id);
        if (index === -1) {
            this.cart.push(item);
        } else {
            this.cart[index].quantity++;
        }
        
        this._saveCart();
    }
    
    changeQuantity(id, quantity) {
        let index = this.cart.findIndex((i) => i.id === id);
        if (index === -1) {
            return
        }

        this.cart[index].quantity = quantity;
        this._saveCart();
    }

    removeCartItem(id) {
        this.cart = this.cart.filter(i => i.id !== id);
        this._saveCart();
    }
    
    clearCart() {
        this.cart = [];
        this._saveCart();
    }
    
    getCartTotal() {
        return this.cart.reduce((acc, item) => acc + (item.price * item.quantity), 0);
    }
    
    _saveCart() {
        localStorage.setItem("cart", JSON.stringify(this.cart));
    }
    
    _loadCart() {
        this.cart = JSON.parse(localStorage.getItem("cart") ?? "[]");
    }
}

class Cart {
    storage;
    discount = 0;
    
    constructor(storage) {
        this.storage = storage;
    }
    applyCoupon() {
        let couponCodeInput = document.getElementById("couponCode");
        let couponCodeValue = couponCodeInput.value;
        
        fetch(`/validate-coupon/${couponCodeValue}`, {
            method: "POST",
        })
            .then(response => {
                if (response.status === 500) {
                    throw new Error("An error occurred");
                }
                if (!response.ok) {
                    throw new Error("Invalid coupon");
                }
                return response.json();
            })
            .then(data => {
                this.discount = data.giftCard.priceReduction;
                document.getElementById("couponMessage").innerText = "Valid coupon";
                document.getElementById("couponDiscount").innerText = "Discount: " +  this.discount .toFixed(2) + " €";
                this.redrawTotalPrice();
                couponCodeInput.disabled = true;
                applyCouponButton.disabled = true;
                document.getElementById("couponCodeHidden").value = couponCodeValue;
            })
            .catch(error => {
                document.getElementById("couponMessage").innerText = error.message;
            });
    }
    
    formatItemPrice(item) {
        return (item.price * item.quantity).toFixed(2)  + " €";
    }
    
    formatTotalPrice() {
        return "Total: " + this.getCartTotal() + " €";
    }
    
    redrawTotalPrice() {
        document.getElementById("cartTotal").innerText = this.formatTotalPrice();
    }
    
    getCartTotal() {
        return (this.storage.getCartTotal() - this.discount).toFixed(2);
    }
    
    renderCart(elementToRender) {
        const cartItems = storage.getCart();

        if (cartItems.length === 0) {
            let h2 = document.createElement("h2");
            h2.className = "text-2xl text-center w-full";
            h2.innerText = "Cart is empty";
            elementToRender.appendChild(h2);
        }

        let discount = document.createElement("div");
        discount.className = "flex items-center justify-end mb-2 text-2xl font-bold";
        discount.id = "couponDiscount";

        let total = document.createElement("div");
        total.className = "flex items-center justify-end mb-2 text-2xl font-bold mt-3";
        total.innerText = this.formatTotalPrice();
        total.id = "cartTotal";
        
        for (let index in cartItems) {
            let item = cartItems[index];
            let row = document.createElement("div");
            row.className = "flex items-center justify-between mb-2";
            row.id = `cartItem-${item.id}`;

            let title = document.createElement("div");
            title.className = "w-1/3 text-xl font-bold";
            title.innerText = item.name;

            let quantity = document.createElement("div");
            quantity.className = "w-1/3";

            let price = document.createElement("div");
            price.className = "w-1/3";
            price.innerText = this.formatItemPrice(item);

            let quantityInput = document.createElement("input");
            quantityInput.className = "input input-bordered w-full max-w-xs";
            quantityInput.type = "number";
            quantityInput.value = item.quantity;
            quantityInput.name = `OrderItems[${index}][quantity]`;
            quantityInput.addEventListener("change",  () => {
                let value = +quantityInput.value;
                if (value < 1) {
                    storage.removeCartItem(item.id);
                } else {
                    storage.changeQuantity(item.id, value)
                    price.innerText = this.formatItemPrice(item);
                }
                this.redrawTotalPrice();
            });

            let removeButton = document.createElement("button");
            removeButton.className = "text-red-500";
            removeButton.addEventListener("click",  ()=> {
                storage.removeCartItem(item.id);
                row.remove();
                this.redrawTotalPrice();
            });

            let removeButtonIcon = document.createElement("i");
            removeButtonIcon.className = "fas fa-trash";
            removeButton.appendChild(removeButtonIcon);

            let hiddenInput = document.createElement("input");
            hiddenInput.type = "hidden";
            hiddenInput.name = `OrderItems[${index}][bookId]`;
            hiddenInput.value = item.id;

            quantity.appendChild(quantityInput);

            row.appendChild(title);
            row.appendChild(quantity);
            row.appendChild(price);
            row.appendChild(removeButton);
            row.appendChild(hiddenInput);

            cartRendering.appendChild(row);
        }

        cartRendering.appendChild(discount);
        cartRendering.appendChild(total);
    }
}

const storage = new Storage();

const addToCartButtons = document.getElementsByClassName("addToCart");
for (let index in addToCartButtons) {
    let element = addToCartButtons[index];
    if (!element.dataset) continue;
    element.addEventListener("click", function () {
        let bookItem = JSON.parse(element.dataset.book);
        bookItem.quantity = 1;
        storage.addCartItem(bookItem);
        
        let toast = document.getElementById("toastContainer")
        let alert = document.createElement("div");
        alert.className = "alert alert-success";
        alert.innerText = "Item was added to cart";
        toast.appendChild(alert);
        
        setTimeout(function () {
            toast.remove();
        }, 1000 * 20)
    });
}

const cart = new Cart(storage);

const cartRendering = document.getElementById("cartRendering");
if (cartRendering) {
    cart.renderCart(cartRendering);
}

const urlParams = new URLSearchParams(window.location.search);
if (urlParams.has("ClearCart")) {
    storage.clearCart();
    history.pushState({}, document.title, window.location.pathname);
}

const applyCouponButton = document.getElementById("applyCoupon");
if (applyCouponButton) {
    applyCouponButton.addEventListener("click", function () {
        cart.applyCoupon();
    });
}
