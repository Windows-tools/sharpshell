﻿using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using SharpShell.Attributes;
using SharpShell.SharpPropertySheet;

namespace FileTimesPropertySheet
{
    /// <summary>
    /// The ResourcesPropertySheet is a shell extension to show the managed 
    /// and unmanaged resources containing in binary files.
    /// </summary>
    [ComVisible(true)]
    [COMServerAssociation(AssociationType.AllFiles)]
    public class FileTimesPropertySheet : SharpPropertySheet
    {
        /// <summary>
        /// Determines whether this instance can show a shell property sheet, given the specified selected file list.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance should show a shell property sheet for the specified file list; otherwise, <c>false</c>.
        /// </returns>
        protected override bool CanShowSheet()
        {
            //  We will only show the resources pages if we have ONE file selected.
            return SelectedItemPaths.Count() == 1;
        }

        /// <summary>
        /// Creates the pages.
        /// </summary>
        /// <returns>
        /// The property sheet pages.
        /// </returns>
        protected override IEnumerable<SharpPropertyPage> CreatePages()
        {
            //  Create the property sheet page.
            var page = new FileTimesPropertyPage();

            //  Return the pages we've created.
            return new[] {page};
        }
    }
}
