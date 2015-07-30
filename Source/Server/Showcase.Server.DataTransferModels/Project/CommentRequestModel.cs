﻿namespace Showcase.Server.DataTransferModels.Project
{
    using System.ComponentModel.DataAnnotations;

    using Showcase.Data.Common;

    public class CommentRequestModel
    {
        [Required]
        [MinLength(ValidationConstants.MinCommentContentLength)]
        [MaxLength(ValidationConstants.MaxCommentContentLength)]
        public string CommentText { get; set; }
    }
}