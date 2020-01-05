﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ExtCore.Infrastructure;

namespace Platformus.Forms
{
  /// <summary>
  /// Overrides the <see cref="ExtensionBase">ExtensionBase</see> class and provides the Platformus.Forms extension information.
  /// </summary>
  public class FormsExtension : ExtensionBase
  {
    /// <summary>
    /// Gets the name of the extension.
    /// </summary>
    public override string Name => "Platformus.Forms";

    /// <summary>
    /// Gets the URL of the extension.
    /// </summary>
    public override string Url => "http://platformus.net/";

    /// <summary>
    /// Gets the version of the extension.
    /// </summary>
    public override string Version => "1.1.0-beta1";

    /// <summary>
    /// Gets the authors of the extension (separated by commas).
    /// </summary>
    public override string Authors => "Dmitry Sikorsky";
  }
}