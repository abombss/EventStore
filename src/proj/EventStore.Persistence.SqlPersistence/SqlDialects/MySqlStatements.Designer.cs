﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventStore.Persistence.SqlPersistence.SqlDialects {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class MySqlStatements {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MySqlStatements() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EventStore.Persistence.SqlPersistence.SqlDialects.MySqlStatements", typeof(MySqlStatements).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
        ///START TRANSACTION;
        ///
        ///CREATE TABLE IF NOT EXISTS Streams
        ///(
        ///       StreamId binary(16) NOT NULL CHECK (StreamId != 0),
        ///       Name nvarchar(256) NOT NULL,
        ///       HeadRevision bigint NOT NULL CHECK (HeadRevision &gt; 0),
        ///       SnapshotRevision bigint NOT NULL CHECK (SnapshotRevision &gt;= 0),
        ///       CONSTRAINT PK_Streams PRIMARY KEY (StreamId)
        ///);
        ///
        ///CREATE TABLE IF NOT EXISTS Commits
        ///(
        ///       StreamId binary(16) NOT NULL,
        ///       CommitId binary(16) NOT NULL  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InitializeStorage {
            get {
                return ResourceManager.GetString("InitializeStorage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SET autocommit=0;
        ///SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
        ///
        ///START TRANSACTION;
        ///
        ///INSERT
        ///  INTO Streams
        ///     ( StreamId, Name, HeadRevision )
        ///SELECT @StreamId, COALESCE(@StreamName, &apos;&apos;), @StreamRevision
        ///  FROM Dual
        /// WHERE @ExpectedRevision = 0
        ///   AND NOT EXISTS
        ///     ( SELECT *
        ///         FROM Streams
        ///        WHERE StreamId = @StreamId );
        ///
        ///UPDATE Streams
        ///    SET HeadRevision = @StreamRevision,
        ///       Name = COALESCE(@StreamName, Name)
        /// WHERE @ExpectedRevision &gt; 0
        ///   AND StreamId = @Str [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PersistCommitAttempt {
            get {
                return ResourceManager.GetString("PersistCommitAttempt", resourceCulture);
            }
        }
    }
}