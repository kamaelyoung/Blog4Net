﻿using System.Collections.Generic;
using Blog4Net.Core.Domain;

namespace Blog4Net.Core.DAL.Repositories
{
    public interface IBlogRepository
    {
        IList<Post> Posts(int pageNumber, int pageSize);
        IList<Post> Posts(int pageNumber, int pageSize, string sortColumn, bool sortByAscending);
        int TotalPosts(bool publishedOnly = true);
        
        IList<Post> PostsForCategory(string categorySlug, int pageNumber, int pageSize);
        int TotalPostsForCategory(string categorySlug);
        
        Category Category(string categorySlug);
        Category Category(int id);

        IList<Post> PostsForTag(string tagSlug, int pageNumber, int pageSize);
        int TotalPostsForTag(string tagSlug);
        
        Tag Tag(string tagSlug);
        Tag Tag(int id);

        IList<Post> SearchPosts(string searchCriteria, int pageNumber, int pageSize);
        int TotalSearchPosts(string searchCritera);

        Post Post(int year, int month, string titleSlug);

        IList<Category> Categories();
        IList<Tag> Tags();

        int AddPost(Post post);        
    }
}