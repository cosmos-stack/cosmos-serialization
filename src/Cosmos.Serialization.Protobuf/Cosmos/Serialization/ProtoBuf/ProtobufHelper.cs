namespace Cosmos.Serialization.ProtoBuf;

public static partial class ProtobufHelper
{
   private static class Man
   {
      private static readonly Lazy<RuntimeTypeModel> _model = new(CreateTypeModel);

      public static RuntimeTypeModel TypeModel => _model.Value;

      private static RuntimeTypeModel CreateTypeModel()
      {
         var typeModel = RuntimeTypeModel.Create();
         typeModel.UseImplicitZeroDefaults = false;
         return typeModel;
      }
   }

   public static RuntimeTypeModel GetTypeModel() => Man.TypeModel;

   private static Task<T> Async<T>(Func<T> func, CancellationToken cancellationToken = default)
   {
      return Task.Run(func.Invoke, cancellationToken);
   }
}