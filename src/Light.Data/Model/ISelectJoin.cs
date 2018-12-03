﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Light.Data
{
	/// <summary>
	/// Join select.
	/// </summary>
	public interface ISelectJoin<K> : IEnumerable<K>
	{
        /// <summary>
        /// To the list.
        /// </summary>
        /// <returns>The list.</returns>
        List<K> ToList ();

		/// <summary>
		/// To the array.
		/// </summary>
		/// <returns>The array.</returns>
		K[] ToArray();

		/// <summary>
		/// Get first instance.
		/// </summary>
		K First ();

		/// <summary>
		/// Elements at index.
		/// </summary>
		/// <returns>The <see cref="!:K"/>.</returns>
		/// <param name="index">Index.</param>
		K ElementAt (int index);

        #region async

        /// <summary>
        /// To the list.
        /// </summary>
        /// <returns>The list.</returns>
        Task<List<K>> ToListAsync(CancellationToken cancellationToken = default(CancellationToken));
        
        /// <summary>
        /// To the array.
        /// </summary>
        /// <returns>The array.</returns>
        Task<K[]> ToArrayAsync(CancellationToken cancellationToken = default(CancellationToken));
        
        /// <summary>
        /// Get first instance.
        /// </summary>
        Task<K> FirstAsync(CancellationToken cancellationToken = default(CancellationToken));
        
        /// <summary>
        /// Elements at index.
        /// </summary>
        /// <returns>The <see cref="!:K"/>.</returns>
        /// <param name="index">Index.</param>
        Task<K> ElementAtAsync(int index, CancellationToken cancellationToken = default(CancellationToken));
        
        #endregion
    }
}
