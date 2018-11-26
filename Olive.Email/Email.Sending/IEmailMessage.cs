﻿using Olive.Entities;
using System;

namespace Olive.Email
{
    /// <summary>
    /// Represents an email generated by the application.
    /// </summary>
    [LogEvents(false), CacheObjects(false)]
    public interface IEmailMessage : IEntity
    {
        /// <summary>
        /// Gets or sets the body of this email.
        /// </summary>
        string Body { get; set; }

        /// <summary>Gets or sets the Date this email becomes sendable.</summary>
        DateTime SendableDate { get; set; }

        /// <summary>Gets or sets whether this email is HTML.</summary>
        bool Html { get; set; }

        /// <summary>Gets or sets the From Address of this email.</summary>
        string FromAddress { get; set; }

        /// <summary>Gets or sets the From Name for this email.</summary>
        string FromName { get; set; }

        /// <summary>Gets or sets the ReplyTo Address of this email.</summary>
        string ReplyToAddress { get; set; }

        /// <summary>Gets or sets the ReplyTo Name for this email.</summary>
        string ReplyToName { get; set; }

        /// <summary>
        /// Gets or sets the Subject of this email.
        /// </summary>
        string Subject { get; set; }

        /// <summary>
        /// Gets or sets the recipient of this email.
        /// </summary>
        string To { get; set; }

        /// <summary>
        /// Gets or sets the Attachments information for this email.
        /// </summary>
        string Attachments { get; set; }

        /// <summary>
        /// Gets or sets the Bcc recipients of this email.
        /// </summary>
        string Bcc { get; set; }

        /// <summary>
        /// Gets or sets the Bcc recipients of this email.
        /// </summary>
        string Cc { get; set; }

        /// <summary>
        /// Gets or sets the number of times sending this email has been tried.
        /// </summary>
        int Retries { get; set; }

        /// <summary>
        /// Gets or sets the VCalendar View of this email.
        /// </summary>
        string VCalendarView { get; set; }
    }
}