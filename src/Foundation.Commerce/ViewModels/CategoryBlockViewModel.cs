﻿using System.Collections.Generic;
using Foundation.Cms.Blocks;
using Foundation.Cms.ViewModels;
using Foundation.Commerce.Models.Blocks;

namespace Foundation.Commerce.ViewModels
{
    public class CategoryBlockViewModel : BlockViewModel<CategoryBlock>
    {
        public CategoryBlockViewModel(CategoryBlock currentBlock) : base(currentBlock)
        {
        }

        public string Heading { get; set; }
        public List<CategoryItemViewModel> CategoryItems { get; set; }
    }

    public class CategoryItemViewModel
    {
        public string Name { get; set; }
        public string Uri { get; set; }
        public string ImageUrl { get; set; }
        public List<CategoryChildLinkViewModel> ChildLinks { get; set; }
    }

    public class CategoryChildLinkViewModel
    {
        public string Text { get; set; }
        public string Uri { get; set; }
    }
}