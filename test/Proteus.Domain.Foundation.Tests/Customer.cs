﻿/*
 *
 * Proteus
 * Copyright (c) 2008 - 2011
 * Stephen A. Bohlen
 * http://www.unhandled-exceptions.com
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 */ 



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proteus.Domain.Foundation.Tests
{
    public class Customer : Proteus.Domain.Foundation.IdentityPersistenceBase<Customer, Guid, string>
    {
        private string _firstname;
        public virtual string Firstname
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
            }
        }
        private string _lastname;
        public virtual string Lastname
        {
            get { return _lastname; }
            set
            {
                _lastname = value;
            }
        }
        

    }
}