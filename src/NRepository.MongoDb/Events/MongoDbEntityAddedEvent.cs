namespace NRepository.MongoDb.Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using NRepository.Core.Events;
    using NRepository.Core.Command;
    using MongoDB.Driver;

    public class MongoDbEntityAddedEvent : EntityAddedEvent
    {
        public MongoDbEntityAddedEvent(ICommandRepository commandRepository, object entity, WriteConcernResult result)
            : base(commandRepository, entity)
        {
            WriteConcernResult = result;
        }

        public WriteConcernResult WriteConcernResult
        {
            get;
            private set;
        }
    }
}
