using System.Collections.Generic;

namespace CourseLibraryAPI.Services
{
    public interface IPropertyMappingService
    {
        Dictionary<string, PropertyMappingValue> GetPropertyMapping<TSource, TDestination>();
        bool ValidMappingExistFor<TSource, TDestination>(string fields);
    }
}