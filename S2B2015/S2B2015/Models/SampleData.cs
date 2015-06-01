// ----------------------------------------------------------------------------------
// Microsoft Developer & Platform Evangelism
// 
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// ----------------------------------------------------------------------------------
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace S2B2015.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<StoreEntities>
    {
        protected override void Seed(StoreEntities context)
        {
            const string ImgUrl = "~/Content/Images/placeholder.png";

            var categoria = AddCategorias(context);
            //var artists = AddArtists(context);
            //AddAlbums(context, ImgUrl, genres, artists);

            context.SaveChanges();
        }
        /*
        private static void AddAlbums(StoreEntities context, string imgUrl, List<Genre> genres, List<Artist> artists)
        {
            context.Albums.Add(new Album { Title = "...And Justice For All", Genre = genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Metallica"), AlbumArtUrl = imgUrl });
        }

        private static List<Artist> AddArtists(MusicStoreEntities context)
        {
            var artists = new List<Artist>
            {
              
                new Genre { Name = "World" }
            };

            genres.ForEach(s => context.Genres.Add(s));
            context.SaveChanges();
            return genres;
        }*/

        private static List<Categoria> AddCategorias(StoreEntities context)
        {
            var categorias = new List<Categoria>
            {
                new Categoria { strTitulo = "Eletroeletronico", strDescrição="Produtos " },
                
            };

            categorias.ForEach(s => context.Categorias.Add(s));
            context.SaveChanges();
            return categorias;
        }
    }
}
  