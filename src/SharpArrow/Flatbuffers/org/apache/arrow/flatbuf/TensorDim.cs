// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace org.apache.arrow.flatbuf
{

using global::System;
using global::FlatBuffers;

/// Shape data for a single axis in a tensor
public struct TensorDim : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static TensorDim GetRootAsTensorDim(ByteBuffer _bb) { return GetRootAsTensorDim(_bb, new TensorDim()); }
  public static TensorDim GetRootAsTensorDim(ByteBuffer _bb, TensorDim obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public TensorDim __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  /// Length of dimension
  public long Size { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  /// Name of the dimension, optional
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }

  public static Offset<TensorDim> CreateTensorDim(FlatBufferBuilder builder,
      long size = 0,
      StringOffset nameOffset = default(StringOffset)) {
    builder.StartObject(2);
    TensorDim.AddSize(builder, size);
    TensorDim.AddName(builder, nameOffset);
    return TensorDim.EndTensorDim(builder);
  }

  public static void StartTensorDim(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddSize(FlatBufferBuilder builder, long size) { builder.AddLong(0, size, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static Offset<TensorDim> EndTensorDim(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<TensorDim>(o);
  }
};


}
