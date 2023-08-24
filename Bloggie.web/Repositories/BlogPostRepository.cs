﻿using Bloggie.web.Data;
using Bloggie.web.Models.Domain;

namespace Bloggie.web.Repositories
{
	public class BlogPostRepository : IBlogPostRepository
	{
		private readonly BloggieDbContext bloggieDbContext;

		public BlogPostRepository(BloggieDbContext bloggieDbContext)
		{
			this.bloggieDbContext = bloggieDbContext;
		}

		public async Task<BlogPost> AddAsync(BlogPost blogPost)
		{
			await bloggieDbContext.AddAsync(blogPost);
			await bloggieDbContext.SaveChangesAsync();
			return blogPost;
		}

		public Task<BlogPost?> DeleteAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<BlogPost>> GetAllAsync()
		{
			return await bloggieDbContext.BlogPosts.ToListAsync();
		}

		public Task<BlogPost?> GetAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<BlogPost?> UpdateAsync(BlogPost blogPost)
		{
			throw new NotImplementedException();
		}
	}
}