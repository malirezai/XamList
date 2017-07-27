﻿using System;
#if API
using System.Data.Linq.Mapping;
#else
using SQLite;
#endif

namespace XamList.Shared
{
#if API
    [Table(Name = "ContactModels")]
#endif
    public class ContactModel
    {
        #region Constructors
        public ContactModel() => Id = Guid.NewGuid().ToString();
        #endregion

#region Properties
#if API
#else
        public string FullName => $"{FirstName} {LastName}";
#endif

#if API
        [Column(Name = nameof(Id), IsPrimaryKey = true, CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
#else
        [PrimaryKey, Unique]
#endif
        public string Id { get; set; }
#if API
        [Column(Name = nameof(FirstName), IsPrimaryKey = false, CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
#endif
        public string FirstName { get; set; }

#if API
        [Column(Name = nameof(LastName), IsPrimaryKey = false, CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
#endif
        public string LastName { get; set; }

#if API
        [Column(Name = nameof(PhoneNumber), IsPrimaryKey = false, CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
#endif
        public string PhoneNumber { get; set; }
#endregion
    }
}
