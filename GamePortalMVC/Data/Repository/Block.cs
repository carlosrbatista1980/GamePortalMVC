using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;
using GamePortalMVC.Data.Repositories.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace GamePortalMVC.Data.Repositories
{
    public class Block : Entity
    {
        [Key]
        public int id { get; set; } //[Auth].[block].id
        public string account { get; set; } //[Auth].[block].account
        public int account_id { get; set; } //[Auth].[block].account_id
        public DateTime date { get; set; } //[Auth].[block].date
        public DateTime unban_date { get; set; } //[Auth].[block].unban_date
        public string ban_owner { get; set; } //[Auth].[block].ban_owner
        public string ban_disc { get; set; } //[Auth].[block].ban_disc
        public int typeBlock { get; set; } //[Auth].[block].typeblock

        /* Database [Auth]
            [id] [int] IDENTITY(1,1) NOT NULL,
	        [account] [varchar](50) NOT NULL,
	        [account_id] [int] NOT NULL,
	        [date] [datetime] NOT NULL,
	        [unban_date] [datetime] NOT NULL,
	        [ban_owner] [varchar](50) NOT NULL,
	        [ban_disc] [varchar](max) NOT NULL,
	        [typeBlock] [int] NOT NULL,
         */

        public virtual Account Account { get; set; }

        public Block()
        {
        }
    }
}
