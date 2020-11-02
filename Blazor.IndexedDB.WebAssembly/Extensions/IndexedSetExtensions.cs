﻿using System;
using System.Linq.Expressions;

namespace Blazor.IndexedDB.WebAssembly.Extensions
{
    public static class IndexedSetExtensions
    {
        public static IndexedSet<TEntity> Include<TEntity, TProperty>(this IndexedSet<TEntity> source, Expression<Func<TEntity, TProperty>> navigationPropertyPath) where TEntity : new()
        {
            var lambda = navigationPropertyPath as LambdaExpression;
            var member = lambda.Body as MemberExpression;

            return source;
        }
    }
}
