﻿namespace AngleSharp.DOM.Html
{
    using System;

    /// <summary>
    /// Represents the keygen HTML element.
    /// </summary>
    [DomName("HTMLKeygenElement")]
    public interface IHtmlKeygenElement : IHtmlElement
    {
        /// <summary>
        /// Gets or sets the autofocus HTML attribute, which indicates whether the
        /// control should have input focus when the page loads.
        /// </summary>
        [DomName("autofocus")]
        Boolean Autofocus { get; set; }

        /// <summary>
        /// Gets the list of assigned labels.
        /// </summary>
        [DomName("labels")]
        INodeList Labels { get; }

        /// <summary>
        /// Gets or sets if the keygen is enabled or disabled.
        /// </summary>
        [DomName("disabled")]
        Boolean IsDisabled { get; set; }

        /// <summary>
        /// Gets the associated HTML form element.
        /// </summary>
        [DomName("form")]
        IHtmlFormElement Form { get; }

        /// <summary>
        /// Gets or sets the name of the element.
        /// </summary>
        [DomName("name")]
        String Name { get; set; }

        /// <summary>
        /// Gets the type of input control (keygen).
        /// </summary>
        [DomName("type")]
        String Type { get; }

        /// <summary>
        /// Gets or sets the type of key used.
        /// </summary>
        [DomName("keytype")]
        String Keytype { get; set; }

        /// <summary>
        /// Gets or sets the challenge attribute.
        /// </summary>
        [DomName("challenge")]
        String Challenge { get; set; }

        /// <summary>
        /// Gets a value if the current element validates.
        /// </summary>
        [DomName("willValidate")]
        Boolean WillValidate { get; }

        /// <summary>
        /// Gets the current validation state of the current element.
        /// </summary>
        [DomName("validity")]
        IValidityState Validity { get; }

        /// <summary>
        /// Gets the current validation message.
        /// </summary>
        [DomName("validationMessage")]
        String ValidationMessage { get; }

        /// <summary>
        /// Checks the validity of the current element.
        /// </summary>
        /// <returns>True if the object is valid, otherwise false.</returns>
        [DomName("checkValidity")]
        Boolean CheckValidity();

        /// <summary>
        /// Sets a custom validation error. If this is not the empty string,
        /// then the element is suffering from a custom validation error.
        /// </summary>
        /// <param name="error">The error message to use.</param>
        [DomName("setCustomValidity")]
        void SetCustomValidity(String error);
    }
}