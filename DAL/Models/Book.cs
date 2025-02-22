﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public class Book : BaseEntity
{
    [Required]
    [MinLength(1)]
    public required string Name { get; set; }

    [Required]
    [MinLength(1)]
    public required string ISBN { get; set; }

    [Required]
    public required string Description { get; set; }

    [Required]
    public required DateOnly PublishDate { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public required int Pages { get; set; }

    [Required]
    [Range(1, 5)]
    public required double Rating { get; set; }

    [Required]
    [Range(0, double.MaxValue)]
    public required double Price { get; set; }

    public string PreviewImageId { get; set; } = "0";

    public int PublisherId { get; set; }

    [ForeignKey(nameof(PublisherId))]
    public virtual Publisher? Publisher { get; set; }

    public int PrimaryGenreId { get; set; }

    [ForeignKey(nameof(PrimaryGenreId))]
    public virtual Genre? PrimaryGenre { get; set; }

    public virtual IEnumerable<BookAuthor>? BookAuthors { get; set; }

    public virtual IEnumerable<BookGenre>? BookGenres { get; set; }

    public virtual IEnumerable<Review>? Reviews { get; set; }

    public virtual IEnumerable<BookImage>? Images { get; set; }
}
