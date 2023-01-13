using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace KendiProjem.Models;

public partial class Artist
{
    public long ArtistId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Album> Albums { get; } = new List<Album>();

    [NotMapped]
    public int stars { get; set; }
}

public abstract class BaseEntity : Microsoft.WindowsAzure.MediaServices.Client.IMediaContextContainer
{
    public virtual ICollection<Artist> Artists { get; set; }
    public abstract string Name { get; set; }
    public virtual ICollection<Album> Albums { get; }

}