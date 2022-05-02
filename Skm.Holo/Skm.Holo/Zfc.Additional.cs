#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
namespace ZeroFormatter
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::ZeroFormatter.Formatters;
    using global::ZeroFormatter.Internal;
    using global::ZeroFormatter.Segments;
    using global::ZeroFormatter.Comparers;

    public static partial class ZeroFormatterInitializer
    {
        static bool registered = false;

        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Register()
        {
            if(registered) return;
            registered = true;
            // Enums
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.AnimationPathType>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.AnimationPathTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Skm.Holo.AnimationPathType>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.AnimationPathTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.AnimationPathType?>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.NullableAnimationPathTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Skm.Holo.AnimationPathType?>.Register(new NullableEqualityComparer<global::Skm.Holo.AnimationPathType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.ComponentType>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.ComponentTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Skm.Holo.ComponentType>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.ComponentTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.ComponentType?>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.NullableComponentTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Skm.Holo.ComponentType?>.Register(new NullableEqualityComparer<global::Skm.Holo.ComponentType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.FileHeader.Keys>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.FileHeader_KeysFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Skm.Holo.FileHeader.Keys>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.FileHeader_KeysEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.FileHeader.Keys?>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.NullableFileHeader_KeysFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Skm.Holo.FileHeader.Keys?>.Register(new NullableEqualityComparer<global::Skm.Holo.FileHeader.Keys>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.LightType>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.LightTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Skm.Holo.LightType>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.LightTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.LightType?>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.NullableLightTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Skm.Holo.LightType?>.Register(new NullableEqualityComparer<global::Skm.Holo.LightType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.ShaderId>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.ShaderIdFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Skm.Holo.ShaderId>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.ShaderIdEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.ShaderId?>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.NullableShaderIdFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Skm.Holo.ShaderId?>.Register(new NullableEqualityComparer<global::Skm.Holo.ShaderId>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.SKMXContainer.SubDir>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.SKMXContainer_SubDirFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Skm.Holo.SKMXContainer.SubDir>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.SKMXContainer_SubDirEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.SKMXContainer.SubDir?>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.NullableSKMXContainer_SubDirFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Skm.Holo.SKMXContainer.SubDir?>.Register(new NullableEqualityComparer<global::Skm.Holo.SKMXContainer.SubDir>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.SKMXContainer.StatusMsg>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.SKMXContainer_StatusMsgFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Skm.Holo.SKMXContainer.StatusMsg>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.SKMXContainer_StatusMsgEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.SKMXContainer.StatusMsg?>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.NullableSKMXContainer_StatusMsgFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Skm.Holo.SKMXContainer.StatusMsg?>.Register(new NullableEqualityComparer<global::Skm.Holo.SKMXContainer.StatusMsg>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Texture.DataFormat>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.Texture_DataFormatFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Skm.Holo.Texture.DataFormat>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.Texture_DataFormatEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Texture.DataFormat?>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.NullableTexture_DataFormatFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Skm.Holo.Texture.DataFormat?>.Register(new NullableEqualityComparer<global::Skm.Holo.Texture.DataFormat>());
            
            // Objects
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.AnimationPath>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.AnimationPathFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Animation>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.AnimationFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.GameObject>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.GameObjectFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Light>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.LightFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.LineFilter>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.LineFilterFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Texture>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.TextureFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Material>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.MaterialFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Mesh>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.MeshFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.MeshFilter>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.MeshFilterFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.PointFilter>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.PointFilterFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.PropertyCollection>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.PropertyCollectionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Transform>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.TransformFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.SmobPreferences>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.SmobPreferencesFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.SKMMobileObject>.Register(new ZeroFormatter.DynamicObjectSegments.Skm.Holo.SKMMobileObjectFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            // Structs
            {
                var structFormatter = new ZeroFormatter.DynamicObjectSegments.Skm.Holo.KeyframeFormatter<ZeroFormatter.Formatters.DefaultResolver>();
                ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Keyframe>.Register(structFormatter);
                ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Keyframe?>.Register(new global::ZeroFormatter.Formatters.NullableStructFormatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Keyframe>(structFormatter));
            }
            {
                var structFormatter = new ZeroFormatter.DynamicObjectSegments.Skm.Holo.ColorFormatter<ZeroFormatter.Formatters.DefaultResolver>();
                ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Color>.Register(structFormatter);
                ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Color?>.Register(new global::ZeroFormatter.Formatters.NullableStructFormatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Color>(structFormatter));
            }
            {
                var structFormatter = new ZeroFormatter.DynamicObjectSegments.Skm.Holo.Vector3Formatter<ZeroFormatter.Formatters.DefaultResolver>();
                ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Vector3>.Register(structFormatter);
                ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Vector3?>.Register(new global::ZeroFormatter.Formatters.NullableStructFormatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Vector3>(structFormatter));
            }
            {
                var structFormatter = new ZeroFormatter.DynamicObjectSegments.Skm.Holo.BoundsFormatter<ZeroFormatter.Formatters.DefaultResolver>();
                ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Bounds>.Register(structFormatter);
                ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Bounds?>.Register(new global::ZeroFormatter.Formatters.NullableStructFormatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Bounds>(structFormatter));
            }
            {
                var structFormatter = new ZeroFormatter.DynamicObjectSegments.Skm.Holo.Vector4Formatter<ZeroFormatter.Formatters.DefaultResolver>();
                ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Vector4>.Register(structFormatter);
                ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Vector4?>.Register(new global::ZeroFormatter.Formatters.NullableStructFormatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Vector4>(structFormatter));
            }
            {
                var structFormatter = new ZeroFormatter.DynamicObjectSegments.Skm.Holo.Vector2Formatter<ZeroFormatter.Formatters.DefaultResolver>();
                ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Vector2>.Register(structFormatter);
                ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Vector2?>.Register(new global::ZeroFormatter.Formatters.NullableStructFormatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Vector2>(structFormatter));
            }
            {
                var structFormatter = new ZeroFormatter.DynamicObjectSegments.Skm.Holo.Matrix4x4Formatter<ZeroFormatter.Formatters.DefaultResolver>();
                ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Matrix4x4>.Register(structFormatter);
                ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Matrix4x4?>.Register(new global::ZeroFormatter.Formatters.NullableStructFormatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Matrix4x4>(structFormatter));
            }
            {
                var structFormatter = new ZeroFormatter.DynamicObjectSegments.Skm.Holo.QuaternionFormatter<ZeroFormatter.Formatters.DefaultResolver>();
                ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Quaternion>.Register(structFormatter);
                ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Quaternion?>.Register(new global::ZeroFormatter.Formatters.NullableStructFormatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Quaternion>(structFormatter));
            }
            // Unions
            {
                var unionFormatter = new ZeroFormatter.DynamicObjectSegments.Skm.Holo.ComponentFormatter<ZeroFormatter.Formatters.DefaultResolver>();
                ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Component>.Register(unionFormatter);
            }
            // Generics
            ZeroFormatter.Formatters.Formatter.RegisterList<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Light>();
            ZeroFormatter.Formatters.Formatter.RegisterDictionary<ZeroFormatter.Formatters.DefaultResolver, string, string>();
            ZeroFormatter.Formatters.Formatter.RegisterArray<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Color>();
            ZeroFormatter.Formatters.Formatter.RegisterArray<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Keyframe>();
            ZeroFormatter.Formatters.Formatter.RegisterArray<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Vector2>();
            ZeroFormatter.Formatters.Formatter.RegisterArray<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Vector3>();
            ZeroFormatter.Formatters.Formatter.RegisterArray<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Vector4>();
            ZeroFormatter.Formatters.Formatter.RegisterCollection<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.AnimationPath, global::System.Collections.Generic.List<global::Skm.Holo.AnimationPath>>();
            ZeroFormatter.Formatters.Formatter.RegisterCollection<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Component, global::System.Collections.Generic.List<global::Skm.Holo.Component>>();
            ZeroFormatter.Formatters.Formatter.RegisterCollection<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.GameObject, global::System.Collections.Generic.List<global::Skm.Holo.GameObject>>();
            ZeroFormatter.Formatters.Formatter.RegisterCollection<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Material, global::System.Collections.Generic.List<global::Skm.Holo.Material>>();
            ZeroFormatter.Formatters.Formatter.RegisterCollection<ZeroFormatter.Formatters.DefaultResolver, global::Skm.Holo.Mesh, global::System.Collections.Generic.List<global::Skm.Holo.Mesh>>();
        }
    }
}
#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
namespace ZeroFormatter.DynamicObjectSegments.Skm.Holo
{
    using global::System;
    using global::ZeroFormatter.Formatters;
    using global::ZeroFormatter.Internal;
    using global::ZeroFormatter.Segments;

    public class AnimationPathFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.AnimationPath>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.AnimationPath value)
        {
            var segment = value as IZeroFormatterSegment;
            if (segment != null)
            {
                return segment.Serialize(ref bytes, offset);
            }
            else if (value == null)
            {
                BinaryUtil.WriteInt32(ref bytes, offset, -1);
                return 4;
            }
            else
            {
                var startOffset = offset;

                offset += (8 + 4 * (1 + 1));
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Keyframe[]>(ref bytes, startOffset, offset, 0, value._Keyframes);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, int>(ref bytes, startOffset, offset, 1, value.Type);

                return ObjectSegmentHelper.WriteSize(ref bytes, startOffset, offset, 1);
            }
        }

        public override global::Skm.Holo.AnimationPath Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = BinaryUtil.ReadInt32(ref bytes, offset);
            if (byteSize == -1)
            {
                byteSize = 4;
                return null;
            }
            return new AnimationPathObjectSegment<TTypeResolver>(tracker, new ArraySegment<byte>(bytes, offset, byteSize));
        }
    }

    public class AnimationPathObjectSegment<TTypeResolver> : global::Skm.Holo.AnimationPath, IZeroFormatterSegment
        where TTypeResolver : ITypeResolver, new()
    {
        static readonly int[] __elementSizes = new int[]{ 0, 4 };

        readonly ArraySegment<byte> __originalBytes;
        readonly global::ZeroFormatter.DirtyTracker __tracker;
        readonly int __binaryLastIndex;
        readonly byte[] __extraFixedBytes;

        CacheSegment<TTypeResolver, global::Skm.Holo.Keyframe[]> __Keyframes;

        // 0
        public override global::Skm.Holo.Keyframe[] _Keyframes
        {
            get
            {
                return __Keyframes.Value;
            }
            set
            {
                __Keyframes.Value = value;
            }
        }

        // 1
        public override int Type
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, int>(__originalBytes, 1, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, int>(__originalBytes, 1, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }


        public AnimationPathObjectSegment(global::ZeroFormatter.DirtyTracker dirtyTracker, ArraySegment<byte> originalBytes)
        {
            var __array = originalBytes.Array;

            this.__originalBytes = originalBytes;
            this.__tracker = dirtyTracker = dirtyTracker.CreateChild();
            this.__binaryLastIndex = BinaryUtil.ReadInt32(ref __array, originalBytes.Offset + 4);

            this.__extraFixedBytes = ObjectSegmentHelper.CreateExtraFixedBytes(this.__binaryLastIndex, 1, __elementSizes);

            __Keyframes = new CacheSegment<TTypeResolver, global::Skm.Holo.Keyframe[]>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 0, __binaryLastIndex, __tracker));
        }

        public bool CanDirectCopy()
        {
            return !__tracker.IsDirty;
        }

        public ArraySegment<byte> GetBufferReference()
        {
            return __originalBytes;
        }

        public int Serialize(ref byte[] targetBytes, int offset)
        {
            if (__extraFixedBytes != null || __tracker.IsDirty)
            {
                var startOffset = offset;
                offset += (8 + 4 * (1 + 1));

                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Keyframe[]>(ref targetBytes, startOffset, offset, 0, ref __Keyframes);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, int>(ref targetBytes, startOffset, offset, 1, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);

                return ObjectSegmentHelper.WriteSize(ref targetBytes, startOffset, offset, 1);
            }
            else
            {
                return ObjectSegmentHelper.DirectCopyAll(__originalBytes, ref targetBytes, offset);
            }
        }
    }

    public class AnimationFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.Animation>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.Animation value)
        {
            var segment = value as IZeroFormatterSegment;
            if (segment != null)
            {
                return segment.Serialize(ref bytes, offset);
            }
            else if (value == null)
            {
                BinaryUtil.WriteInt32(ref bytes, offset, -1);
                return 4;
            }
            else
            {
                var startOffset = offset;

                offset += (8 + 4 * (3 + 1));
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, string>(ref bytes, startOffset, offset, 0, value.Name);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::System.Guid>(ref bytes, startOffset, offset, 1, value.Guid);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, string>(ref bytes, startOffset, offset, 2, value.RelativePath);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.AnimationPath>>(ref bytes, startOffset, offset, 3, value.AnimationPaths);

                return ObjectSegmentHelper.WriteSize(ref bytes, startOffset, offset, 3);
            }
        }

        public override global::Skm.Holo.Animation Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = BinaryUtil.ReadInt32(ref bytes, offset);
            if (byteSize == -1)
            {
                byteSize = 4;
                return null;
            }
            return new AnimationObjectSegment<TTypeResolver>(tracker, new ArraySegment<byte>(bytes, offset, byteSize));
        }
    }

    public class AnimationObjectSegment<TTypeResolver> : global::Skm.Holo.Animation, IZeroFormatterSegment
        where TTypeResolver : ITypeResolver, new()
    {
        static readonly int[] __elementSizes = new int[]{ 0, 16, 0, 0 };

        readonly ArraySegment<byte> __originalBytes;
        readonly global::ZeroFormatter.DirtyTracker __tracker;
        readonly int __binaryLastIndex;
        readonly byte[] __extraFixedBytes;

        CacheSegment<TTypeResolver, string> _Name;
        CacheSegment<TTypeResolver, string> _RelativePath;
        CacheSegment<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.AnimationPath>> _AnimationPaths;

        // 0
        public override string Name
        {
            get
            {
                return _Name.Value;
            }
            set
            {
                _Name.Value = value;
            }
        }

        // 1
        public override global::System.Guid Guid
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, global::System.Guid>(__originalBytes, 1, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, global::System.Guid>(__originalBytes, 1, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 2
        public override string RelativePath
        {
            get
            {
                return _RelativePath.Value;
            }
            set
            {
                _RelativePath.Value = value;
            }
        }

        // 3
        public override global::System.Collections.Generic.List<global::Skm.Holo.AnimationPath> AnimationPaths
        {
            get
            {
                return _AnimationPaths.Value;
            }
            set
            {
                _AnimationPaths.Value = value;
            }
        }


        public AnimationObjectSegment(global::ZeroFormatter.DirtyTracker dirtyTracker, ArraySegment<byte> originalBytes)
        {
            var __array = originalBytes.Array;

            this.__originalBytes = originalBytes;
            this.__tracker = dirtyTracker = dirtyTracker.CreateChild();
            this.__binaryLastIndex = BinaryUtil.ReadInt32(ref __array, originalBytes.Offset + 4);

            this.__extraFixedBytes = ObjectSegmentHelper.CreateExtraFixedBytes(this.__binaryLastIndex, 3, __elementSizes);

            _Name = new CacheSegment<TTypeResolver, string>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 0, __binaryLastIndex, __tracker));
            _RelativePath = new CacheSegment<TTypeResolver, string>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 2, __binaryLastIndex, __tracker));
            _AnimationPaths = new CacheSegment<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.AnimationPath>>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 3, __binaryLastIndex, __tracker));
        }

        public bool CanDirectCopy()
        {
            return !__tracker.IsDirty;
        }

        public ArraySegment<byte> GetBufferReference()
        {
            return __originalBytes;
        }

        public int Serialize(ref byte[] targetBytes, int offset)
        {
            if (__extraFixedBytes != null || __tracker.IsDirty)
            {
                var startOffset = offset;
                offset += (8 + 4 * (3 + 1));

                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, string>(ref targetBytes, startOffset, offset, 0, ref _Name);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, global::System.Guid>(ref targetBytes, startOffset, offset, 1, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, string>(ref targetBytes, startOffset, offset, 2, ref _RelativePath);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.AnimationPath>>(ref targetBytes, startOffset, offset, 3, ref _AnimationPaths);

                return ObjectSegmentHelper.WriteSize(ref targetBytes, startOffset, offset, 3);
            }
            else
            {
                return ObjectSegmentHelper.DirectCopyAll(__originalBytes, ref targetBytes, offset);
            }
        }
    }

    public class GameObjectFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.GameObject>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.GameObject value)
        {
            var segment = value as IZeroFormatterSegment;
            if (segment != null)
            {
                return segment.Serialize(ref bytes, offset);
            }
            else if (value == null)
            {
                BinaryUtil.WriteInt32(ref bytes, offset, -1);
                return 4;
            }
            else
            {
                var startOffset = offset;

                offset += (8 + 4 * (8 + 1));
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.Component>>(ref bytes, startOffset, offset, 0, value.Components);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::System.Guid>(ref bytes, startOffset, offset, 1, value.Guid);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, string>(ref bytes, startOffset, offset, 2, value.Tag);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, string>(ref bytes, startOffset, offset, 3, value.Name);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, string>(ref bytes, startOffset, offset, 5, value.MaterialId);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::System.Guid>(ref bytes, startOffset, offset, 6, value.GeometryGuid);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::System.Guid>(ref bytes, startOffset, offset, 7, value.ParentGuid);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, int>(ref bytes, startOffset, offset, 8, value.ShaderId);

                return ObjectSegmentHelper.WriteSize(ref bytes, startOffset, offset, 8);
            }
        }

        public override global::Skm.Holo.GameObject Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = BinaryUtil.ReadInt32(ref bytes, offset);
            if (byteSize == -1)
            {
                byteSize = 4;
                return null;
            }
            return new GameObjectObjectSegment<TTypeResolver>(tracker, new ArraySegment<byte>(bytes, offset, byteSize));
        }
    }

    public class GameObjectObjectSegment<TTypeResolver> : global::Skm.Holo.GameObject, IZeroFormatterSegment
        where TTypeResolver : ITypeResolver, new()
    {
        static readonly int[] __elementSizes = new int[]{ 0, 16, 0, 0, 0, 0, 16, 16, 4 };

        readonly ArraySegment<byte> __originalBytes;
        readonly global::ZeroFormatter.DirtyTracker __tracker;
        readonly int __binaryLastIndex;
        readonly byte[] __extraFixedBytes;

        CacheSegment<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.Component>> _Components;
        CacheSegment<TTypeResolver, string> _Tag;
        CacheSegment<TTypeResolver, string> _Name;
        CacheSegment<TTypeResolver, string> _MaterialId;

        // 0
        public override global::System.Collections.Generic.List<global::Skm.Holo.Component> Components
        {
            get
            {
                return _Components.Value;
            }
            set
            {
                _Components.Value = value;
            }
        }

        // 1
        public override global::System.Guid Guid
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, global::System.Guid>(__originalBytes, 1, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, global::System.Guid>(__originalBytes, 1, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 2
        public override string Tag
        {
            get
            {
                return _Tag.Value;
            }
            set
            {
                _Tag.Value = value;
            }
        }

        // 3
        public override string Name
        {
            get
            {
                return _Name.Value;
            }
            set
            {
                _Name.Value = value;
            }
        }

        // 5
        public override string MaterialId
        {
            get
            {
                return _MaterialId.Value;
            }
            set
            {
                _MaterialId.Value = value;
            }
        }

        // 6
        public override global::System.Guid GeometryGuid
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, global::System.Guid>(__originalBytes, 6, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, global::System.Guid>(__originalBytes, 6, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 7
        public override global::System.Guid ParentGuid
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, global::System.Guid>(__originalBytes, 7, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, global::System.Guid>(__originalBytes, 7, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 8
        public override int ShaderId
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, int>(__originalBytes, 8, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, int>(__originalBytes, 8, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }


        public GameObjectObjectSegment(global::ZeroFormatter.DirtyTracker dirtyTracker, ArraySegment<byte> originalBytes)
        {
            var __array = originalBytes.Array;

            this.__originalBytes = originalBytes;
            this.__tracker = dirtyTracker = dirtyTracker.CreateChild();
            this.__binaryLastIndex = BinaryUtil.ReadInt32(ref __array, originalBytes.Offset + 4);

            this.__extraFixedBytes = ObjectSegmentHelper.CreateExtraFixedBytes(this.__binaryLastIndex, 8, __elementSizes);

            _Components = new CacheSegment<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.Component>>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 0, __binaryLastIndex, __tracker));
            _Tag = new CacheSegment<TTypeResolver, string>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 2, __binaryLastIndex, __tracker));
            _Name = new CacheSegment<TTypeResolver, string>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 3, __binaryLastIndex, __tracker));
            _MaterialId = new CacheSegment<TTypeResolver, string>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 5, __binaryLastIndex, __tracker));
        }

        public bool CanDirectCopy()
        {
            return !__tracker.IsDirty;
        }

        public ArraySegment<byte> GetBufferReference()
        {
            return __originalBytes;
        }

        public int Serialize(ref byte[] targetBytes, int offset)
        {
            if (__extraFixedBytes != null || __tracker.IsDirty)
            {
                var startOffset = offset;
                offset += (8 + 4 * (8 + 1));

                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.Component>>(ref targetBytes, startOffset, offset, 0, ref _Components);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, global::System.Guid>(ref targetBytes, startOffset, offset, 1, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, string>(ref targetBytes, startOffset, offset, 2, ref _Tag);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, string>(ref targetBytes, startOffset, offset, 3, ref _Name);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, string>(ref targetBytes, startOffset, offset, 5, ref _MaterialId);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, global::System.Guid>(ref targetBytes, startOffset, offset, 6, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, global::System.Guid>(ref targetBytes, startOffset, offset, 7, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, int>(ref targetBytes, startOffset, offset, 8, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);

                return ObjectSegmentHelper.WriteSize(ref targetBytes, startOffset, offset, 8);
            }
            else
            {
                return ObjectSegmentHelper.DirectCopyAll(__originalBytes, ref targetBytes, offset);
            }
        }
    }

    public class LightFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.Light>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.Light value)
        {
            var segment = value as IZeroFormatterSegment;
            if (segment != null)
            {
                return segment.Serialize(ref bytes, offset);
            }
            else if (value == null)
            {
                BinaryUtil.WriteInt32(ref bytes, offset, -1);
                return 4;
            }
            else
            {
                var startOffset = offset;

                offset += (8 + 4 * (7 + 1));
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, int>(ref bytes, startOffset, offset, 0, value.Type);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Color>(ref bytes, startOffset, offset, 1, value.Color);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, string>(ref bytes, startOffset, offset, 2, value.Name);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Vector3>(ref bytes, startOffset, offset, 3, value.Position);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Vector3>(ref bytes, startOffset, offset, 4, value.Direction);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Color>(ref bytes, startOffset, offset, 5, value.AmbientColor);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Color>(ref bytes, startOffset, offset, 6, value.DiffuseColor);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Color>(ref bytes, startOffset, offset, 7, value.SpecularColor);

                return ObjectSegmentHelper.WriteSize(ref bytes, startOffset, offset, 7);
            }
        }

        public override global::Skm.Holo.Light Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = BinaryUtil.ReadInt32(ref bytes, offset);
            if (byteSize == -1)
            {
                byteSize = 4;
                return null;
            }
            return new LightObjectSegment<TTypeResolver>(tracker, new ArraySegment<byte>(bytes, offset, byteSize));
        }
    }

    public class LightObjectSegment<TTypeResolver> : global::Skm.Holo.Light, IZeroFormatterSegment
        where TTypeResolver : ITypeResolver, new()
    {
        static readonly int[] __elementSizes = new int[]{ 4, 0, 0, 0, 0, 0, 0, 0 };

        readonly ArraySegment<byte> __originalBytes;
        readonly global::ZeroFormatter.DirtyTracker __tracker;
        readonly int __binaryLastIndex;
        readonly byte[] __extraFixedBytes;

        CacheSegment<TTypeResolver, global::Skm.Holo.Color> _Color;
        CacheSegment<TTypeResolver, string> _Name;
        CacheSegment<TTypeResolver, global::Skm.Holo.Vector3> _Position;
        CacheSegment<TTypeResolver, global::Skm.Holo.Vector3> _Direction;
        CacheSegment<TTypeResolver, global::Skm.Holo.Color> _AmbientColor;
        CacheSegment<TTypeResolver, global::Skm.Holo.Color> _DiffuseColor;
        CacheSegment<TTypeResolver, global::Skm.Holo.Color> _SpecularColor;

        // 0
        public override int Type
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, int>(__originalBytes, 0, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, int>(__originalBytes, 0, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 1
        public override global::Skm.Holo.Color Color
        {
            get
            {
                return _Color.Value;
            }
            set
            {
                _Color.Value = value;
            }
        }

        // 2
        public override string Name
        {
            get
            {
                return _Name.Value;
            }
            set
            {
                _Name.Value = value;
            }
        }

        // 3
        public override global::Skm.Holo.Vector3 Position
        {
            get
            {
                return _Position.Value;
            }
            set
            {
                _Position.Value = value;
            }
        }

        // 4
        public override global::Skm.Holo.Vector3 Direction
        {
            get
            {
                return _Direction.Value;
            }
            set
            {
                _Direction.Value = value;
            }
        }

        // 5
        public override global::Skm.Holo.Color AmbientColor
        {
            get
            {
                return _AmbientColor.Value;
            }
            set
            {
                _AmbientColor.Value = value;
            }
        }

        // 6
        public override global::Skm.Holo.Color DiffuseColor
        {
            get
            {
                return _DiffuseColor.Value;
            }
            set
            {
                _DiffuseColor.Value = value;
            }
        }

        // 7
        public override global::Skm.Holo.Color SpecularColor
        {
            get
            {
                return _SpecularColor.Value;
            }
            set
            {
                _SpecularColor.Value = value;
            }
        }


        public LightObjectSegment(global::ZeroFormatter.DirtyTracker dirtyTracker, ArraySegment<byte> originalBytes)
        {
            var __array = originalBytes.Array;

            this.__originalBytes = originalBytes;
            this.__tracker = dirtyTracker = dirtyTracker.CreateChild();
            this.__binaryLastIndex = BinaryUtil.ReadInt32(ref __array, originalBytes.Offset + 4);

            this.__extraFixedBytes = ObjectSegmentHelper.CreateExtraFixedBytes(this.__binaryLastIndex, 7, __elementSizes);

            _Color = new CacheSegment<TTypeResolver, global::Skm.Holo.Color>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 1, __binaryLastIndex, __tracker));
            _Name = new CacheSegment<TTypeResolver, string>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 2, __binaryLastIndex, __tracker));
            _Position = new CacheSegment<TTypeResolver, global::Skm.Holo.Vector3>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 3, __binaryLastIndex, __tracker));
            _Direction = new CacheSegment<TTypeResolver, global::Skm.Holo.Vector3>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 4, __binaryLastIndex, __tracker));
            _AmbientColor = new CacheSegment<TTypeResolver, global::Skm.Holo.Color>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 5, __binaryLastIndex, __tracker));
            _DiffuseColor = new CacheSegment<TTypeResolver, global::Skm.Holo.Color>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 6, __binaryLastIndex, __tracker));
            _SpecularColor = new CacheSegment<TTypeResolver, global::Skm.Holo.Color>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 7, __binaryLastIndex, __tracker));
        }

        public bool CanDirectCopy()
        {
            return !__tracker.IsDirty;
        }

        public ArraySegment<byte> GetBufferReference()
        {
            return __originalBytes;
        }

        public int Serialize(ref byte[] targetBytes, int offset)
        {
            if (__extraFixedBytes != null || __tracker.IsDirty)
            {
                var startOffset = offset;
                offset += (8 + 4 * (7 + 1));

                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, int>(ref targetBytes, startOffset, offset, 0, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Color>(ref targetBytes, startOffset, offset, 1, ref _Color);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, string>(ref targetBytes, startOffset, offset, 2, ref _Name);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Vector3>(ref targetBytes, startOffset, offset, 3, ref _Position);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Vector3>(ref targetBytes, startOffset, offset, 4, ref _Direction);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Color>(ref targetBytes, startOffset, offset, 5, ref _AmbientColor);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Color>(ref targetBytes, startOffset, offset, 6, ref _DiffuseColor);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Color>(ref targetBytes, startOffset, offset, 7, ref _SpecularColor);

                return ObjectSegmentHelper.WriteSize(ref targetBytes, startOffset, offset, 7);
            }
            else
            {
                return ObjectSegmentHelper.DirectCopyAll(__originalBytes, ref targetBytes, offset);
            }
        }
    }

    public class LineFilterFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.LineFilter>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.LineFilter value)
        {
            var segment = value as IZeroFormatterSegment;
            if (segment != null)
            {
                return segment.Serialize(ref bytes, offset);
            }
            else if (value == null)
            {
                BinaryUtil.WriteInt32(ref bytes, offset, -1);
                return 4;
            }
            else
            {
                var startOffset = offset;

                offset += (8 + 4 * (2 + 1));
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, string>(ref bytes, startOffset, offset, 0, value.Name);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::System.Guid>(ref bytes, startOffset, offset, 1, value.Guid);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Vector3[]>(ref bytes, startOffset, offset, 2, value.LineSequence);

                return ObjectSegmentHelper.WriteSize(ref bytes, startOffset, offset, 2);
            }
        }

        public override global::Skm.Holo.LineFilter Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = BinaryUtil.ReadInt32(ref bytes, offset);
            if (byteSize == -1)
            {
                byteSize = 4;
                return null;
            }
            return new LineFilterObjectSegment<TTypeResolver>(tracker, new ArraySegment<byte>(bytes, offset, byteSize));
        }
    }

    public class LineFilterObjectSegment<TTypeResolver> : global::Skm.Holo.LineFilter, IZeroFormatterSegment
        where TTypeResolver : ITypeResolver, new()
    {
        static readonly int[] __elementSizes = new int[]{ 0, 16, 0 };

        readonly ArraySegment<byte> __originalBytes;
        readonly global::ZeroFormatter.DirtyTracker __tracker;
        readonly int __binaryLastIndex;
        readonly byte[] __extraFixedBytes;

        CacheSegment<TTypeResolver, string> _Name;
        CacheSegment<TTypeResolver, global::Skm.Holo.Vector3[]> _LineSequence;

        // 0
        public override string Name
        {
            get
            {
                return _Name.Value;
            }
            set
            {
                _Name.Value = value;
            }
        }

        // 1
        public override global::System.Guid Guid
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, global::System.Guid>(__originalBytes, 1, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, global::System.Guid>(__originalBytes, 1, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 2
        public override global::Skm.Holo.Vector3[] LineSequence
        {
            get
            {
                return _LineSequence.Value;
            }
            set
            {
                _LineSequence.Value = value;
            }
        }


        public LineFilterObjectSegment(global::ZeroFormatter.DirtyTracker dirtyTracker, ArraySegment<byte> originalBytes)
        {
            var __array = originalBytes.Array;

            this.__originalBytes = originalBytes;
            this.__tracker = dirtyTracker = dirtyTracker.CreateChild();
            this.__binaryLastIndex = BinaryUtil.ReadInt32(ref __array, originalBytes.Offset + 4);

            this.__extraFixedBytes = ObjectSegmentHelper.CreateExtraFixedBytes(this.__binaryLastIndex, 2, __elementSizes);

            _Name = new CacheSegment<TTypeResolver, string>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 0, __binaryLastIndex, __tracker));
            _LineSequence = new CacheSegment<TTypeResolver, global::Skm.Holo.Vector3[]>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 2, __binaryLastIndex, __tracker));
        }

        public bool CanDirectCopy()
        {
            return !__tracker.IsDirty;
        }

        public ArraySegment<byte> GetBufferReference()
        {
            return __originalBytes;
        }

        public int Serialize(ref byte[] targetBytes, int offset)
        {
            if (__extraFixedBytes != null || __tracker.IsDirty)
            {
                var startOffset = offset;
                offset += (8 + 4 * (2 + 1));

                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, string>(ref targetBytes, startOffset, offset, 0, ref _Name);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, global::System.Guid>(ref targetBytes, startOffset, offset, 1, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Vector3[]>(ref targetBytes, startOffset, offset, 2, ref _LineSequence);

                return ObjectSegmentHelper.WriteSize(ref targetBytes, startOffset, offset, 2);
            }
            else
            {
                return ObjectSegmentHelper.DirectCopyAll(__originalBytes, ref targetBytes, offset);
            }
        }
    }

    public class TextureFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.Texture>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.Texture value)
        {
            var segment = value as IZeroFormatterSegment;
            if (segment != null)
            {
                return segment.Serialize(ref bytes, offset);
            }
            else if (value == null)
            {
                BinaryUtil.WriteInt32(ref bytes, offset, -1);
                return 4;
            }
            else
            {
                var startOffset = offset;

                offset += (8 + 4 * (0 + 1));
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, string>(ref bytes, startOffset, offset, 0, value.DiffuseMapFileName);

                return ObjectSegmentHelper.WriteSize(ref bytes, startOffset, offset, 0);
            }
        }

        public override global::Skm.Holo.Texture Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = BinaryUtil.ReadInt32(ref bytes, offset);
            if (byteSize == -1)
            {
                byteSize = 4;
                return null;
            }
            return new TextureObjectSegment<TTypeResolver>(tracker, new ArraySegment<byte>(bytes, offset, byteSize));
        }
    }

    public class TextureObjectSegment<TTypeResolver> : global::Skm.Holo.Texture, IZeroFormatterSegment
        where TTypeResolver : ITypeResolver, new()
    {
        static readonly int[] __elementSizes = new int[]{ 0 };

        readonly ArraySegment<byte> __originalBytes;
        readonly global::ZeroFormatter.DirtyTracker __tracker;
        readonly int __binaryLastIndex;
        readonly byte[] __extraFixedBytes;

        CacheSegment<TTypeResolver, string> _DiffuseMapFileName;

        // 0
        public override string DiffuseMapFileName
        {
            get
            {
                return _DiffuseMapFileName.Value;
            }
            set
            {
                _DiffuseMapFileName.Value = value;
            }
        }


        public TextureObjectSegment(global::ZeroFormatter.DirtyTracker dirtyTracker, ArraySegment<byte> originalBytes)
        {
            var __array = originalBytes.Array;

            this.__originalBytes = originalBytes;
            this.__tracker = dirtyTracker = dirtyTracker.CreateChild();
            this.__binaryLastIndex = BinaryUtil.ReadInt32(ref __array, originalBytes.Offset + 4);

            this.__extraFixedBytes = ObjectSegmentHelper.CreateExtraFixedBytes(this.__binaryLastIndex, 0, __elementSizes);

            _DiffuseMapFileName = new CacheSegment<TTypeResolver, string>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 0, __binaryLastIndex, __tracker));
        }

        public bool CanDirectCopy()
        {
            return !__tracker.IsDirty;
        }

        public ArraySegment<byte> GetBufferReference()
        {
            return __originalBytes;
        }

        public int Serialize(ref byte[] targetBytes, int offset)
        {
            if (__extraFixedBytes != null || __tracker.IsDirty)
            {
                var startOffset = offset;
                offset += (8 + 4 * (0 + 1));

                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, string>(ref targetBytes, startOffset, offset, 0, ref _DiffuseMapFileName);

                return ObjectSegmentHelper.WriteSize(ref targetBytes, startOffset, offset, 0);
            }
            else
            {
                return ObjectSegmentHelper.DirectCopyAll(__originalBytes, ref targetBytes, offset);
            }
        }
    }

    public class MaterialFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.Material>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.Material value)
        {
            var segment = value as IZeroFormatterSegment;
            if (segment != null)
            {
                return segment.Serialize(ref bytes, offset);
            }
            else if (value == null)
            {
                BinaryUtil.WriteInt32(ref bytes, offset, -1);
                return 4;
            }
            else
            {
                var startOffset = offset;

                offset += (8 + 4 * (5 + 1));
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Texture>(ref bytes, startOffset, offset, 0, value.MainTexture);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Color>(ref bytes, startOffset, offset, 1, value.Color);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, string>(ref bytes, startOffset, offset, 2, value.Id);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, int>(ref bytes, startOffset, offset, 3, value.ShaderId);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 4, value.Shininess);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 5, value.Opacity);

                return ObjectSegmentHelper.WriteSize(ref bytes, startOffset, offset, 5);
            }
        }

        public override global::Skm.Holo.Material Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = BinaryUtil.ReadInt32(ref bytes, offset);
            if (byteSize == -1)
            {
                byteSize = 4;
                return null;
            }
            return new MaterialObjectSegment<TTypeResolver>(tracker, new ArraySegment<byte>(bytes, offset, byteSize));
        }
    }

    public class MaterialObjectSegment<TTypeResolver> : global::Skm.Holo.Material, IZeroFormatterSegment
        where TTypeResolver : ITypeResolver, new()
    {
        static readonly int[] __elementSizes = new int[]{ 0, 0, 0, 4, 4, 4 };

        readonly ArraySegment<byte> __originalBytes;
        readonly global::ZeroFormatter.DirtyTracker __tracker;
        readonly int __binaryLastIndex;
        readonly byte[] __extraFixedBytes;

        global::Skm.Holo.Texture _MainTexture;
        CacheSegment<TTypeResolver, global::Skm.Holo.Color> _Color;
        CacheSegment<TTypeResolver, string> _Id;

        // 0
        public override global::Skm.Holo.Texture MainTexture
        {
            get
            {
                return _MainTexture;
            }
            set
            {
                __tracker.Dirty();
                _MainTexture = value;
            }
        }

        // 1
        public override global::Skm.Holo.Color Color
        {
            get
            {
                return _Color.Value;
            }
            set
            {
                _Color.Value = value;
            }
        }

        // 2
        public override string Id
        {
            get
            {
                return _Id.Value;
            }
            set
            {
                _Id.Value = value;
            }
        }

        // 3
        public override int ShaderId
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, int>(__originalBytes, 3, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, int>(__originalBytes, 3, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 4
        public override float Shininess
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 4, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 4, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 5
        public override float Opacity
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 5, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 5, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }


        public MaterialObjectSegment(global::ZeroFormatter.DirtyTracker dirtyTracker, ArraySegment<byte> originalBytes)
        {
            var __array = originalBytes.Array;

            this.__originalBytes = originalBytes;
            this.__tracker = dirtyTracker = dirtyTracker.CreateChild();
            this.__binaryLastIndex = BinaryUtil.ReadInt32(ref __array, originalBytes.Offset + 4);

            this.__extraFixedBytes = ObjectSegmentHelper.CreateExtraFixedBytes(this.__binaryLastIndex, 5, __elementSizes);

            _MainTexture = ObjectSegmentHelper.DeserializeSegment<TTypeResolver, global::Skm.Holo.Texture>(originalBytes, 0, __binaryLastIndex, __tracker);
            _Color = new CacheSegment<TTypeResolver, global::Skm.Holo.Color>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 1, __binaryLastIndex, __tracker));
            _Id = new CacheSegment<TTypeResolver, string>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 2, __binaryLastIndex, __tracker));
        }

        public bool CanDirectCopy()
        {
            return !__tracker.IsDirty;
        }

        public ArraySegment<byte> GetBufferReference()
        {
            return __originalBytes;
        }

        public int Serialize(ref byte[] targetBytes, int offset)
        {
            if (__extraFixedBytes != null || __tracker.IsDirty)
            {
                var startOffset = offset;
                offset += (8 + 4 * (5 + 1));

                offset += ObjectSegmentHelper.SerializeSegment<TTypeResolver, global::Skm.Holo.Texture>(ref targetBytes, startOffset, offset, 0, _MainTexture);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Color>(ref targetBytes, startOffset, offset, 1, ref _Color);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, string>(ref targetBytes, startOffset, offset, 2, ref _Id);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, int>(ref targetBytes, startOffset, offset, 3, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 4, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 5, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);

                return ObjectSegmentHelper.WriteSize(ref targetBytes, startOffset, offset, 5);
            }
            else
            {
                return ObjectSegmentHelper.DirectCopyAll(__originalBytes, ref targetBytes, offset);
            }
        }
    }

    public class MeshFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.Mesh>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.Mesh value)
        {
            var segment = value as IZeroFormatterSegment;
            if (segment != null)
            {
                return segment.Serialize(ref bytes, offset);
            }
            else if (value == null)
            {
                BinaryUtil.WriteInt32(ref bytes, offset, -1);
                return 4;
            }
            else
            {
                var startOffset = offset;

                offset += (8 + 4 * (14 + 1));
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, int>(ref bytes, startOffset, offset, 1, value.SubMeshCount);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Bounds>(ref bytes, startOffset, offset, 2, value.Bounds);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Vector3[]>(ref bytes, startOffset, offset, 3, value.Normals);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Vector4[]>(ref bytes, startOffset, offset, 4, value.Tangents);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Vector2[]>(ref bytes, startOffset, offset, 5, value.Uv);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Vector2[]>(ref bytes, startOffset, offset, 6, value.Uv2);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Vector2[]>(ref bytes, startOffset, offset, 7, value.Uv3);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Vector2[]>(ref bytes, startOffset, offset, 8, value.Uv4);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Color[]>(ref bytes, startOffset, offset, 9, value.Colors);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Vector3[]>(ref bytes, startOffset, offset, 10, value.Vertices);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Color[]>(ref bytes, startOffset, offset, 11, value.Colors32);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, int[]>(ref bytes, startOffset, offset, 12, value.Triangles);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, string>(ref bytes, startOffset, offset, 13, value.MaterialId);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, int>(ref bytes, startOffset, offset, 14, value.ShaderId);

                return ObjectSegmentHelper.WriteSize(ref bytes, startOffset, offset, 14);
            }
        }

        public override global::Skm.Holo.Mesh Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = BinaryUtil.ReadInt32(ref bytes, offset);
            if (byteSize == -1)
            {
                byteSize = 4;
                return null;
            }
            return new MeshObjectSegment<TTypeResolver>(tracker, new ArraySegment<byte>(bytes, offset, byteSize));
        }
    }

    public class MeshObjectSegment<TTypeResolver> : global::Skm.Holo.Mesh, IZeroFormatterSegment
        where TTypeResolver : ITypeResolver, new()
    {
        static readonly int[] __elementSizes = new int[]{ 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4 };

        readonly ArraySegment<byte> __originalBytes;
        readonly global::ZeroFormatter.DirtyTracker __tracker;
        readonly int __binaryLastIndex;
        readonly byte[] __extraFixedBytes;

        CacheSegment<TTypeResolver, global::Skm.Holo.Bounds> _Bounds;
        CacheSegment<TTypeResolver, global::Skm.Holo.Vector3[]> _Normals;
        CacheSegment<TTypeResolver, global::Skm.Holo.Vector4[]> _Tangents;
        CacheSegment<TTypeResolver, global::Skm.Holo.Vector2[]> _Uv;
        CacheSegment<TTypeResolver, global::Skm.Holo.Vector2[]> _Uv2;
        CacheSegment<TTypeResolver, global::Skm.Holo.Vector2[]> _Uv3;
        CacheSegment<TTypeResolver, global::Skm.Holo.Vector2[]> _Uv4;
        CacheSegment<TTypeResolver, global::Skm.Holo.Color[]> _Colors;
        CacheSegment<TTypeResolver, global::Skm.Holo.Vector3[]> _Vertices;
        CacheSegment<TTypeResolver, global::Skm.Holo.Color[]> _Colors32;
        CacheSegment<TTypeResolver, int[]> _Triangles;
        CacheSegment<TTypeResolver, string> _MaterialId;

        // 1
        public override int SubMeshCount
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, int>(__originalBytes, 1, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, int>(__originalBytes, 1, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 2
        public override global::Skm.Holo.Bounds Bounds
        {
            get
            {
                return _Bounds.Value;
            }
            set
            {
                _Bounds.Value = value;
            }
        }

        // 3
        public override global::Skm.Holo.Vector3[] Normals
        {
            get
            {
                return _Normals.Value;
            }
            set
            {
                _Normals.Value = value;
            }
        }

        // 4
        public override global::Skm.Holo.Vector4[] Tangents
        {
            get
            {
                return _Tangents.Value;
            }
            set
            {
                _Tangents.Value = value;
            }
        }

        // 5
        public override global::Skm.Holo.Vector2[] Uv
        {
            get
            {
                return _Uv.Value;
            }
            set
            {
                _Uv.Value = value;
            }
        }

        // 6
        public override global::Skm.Holo.Vector2[] Uv2
        {
            get
            {
                return _Uv2.Value;
            }
            set
            {
                _Uv2.Value = value;
            }
        }

        // 7
        public override global::Skm.Holo.Vector2[] Uv3
        {
            get
            {
                return _Uv3.Value;
            }
            set
            {
                _Uv3.Value = value;
            }
        }

        // 8
        public override global::Skm.Holo.Vector2[] Uv4
        {
            get
            {
                return _Uv4.Value;
            }
            set
            {
                _Uv4.Value = value;
            }
        }

        // 9
        public override global::Skm.Holo.Color[] Colors
        {
            get
            {
                return _Colors.Value;
            }
            set
            {
                _Colors.Value = value;
            }
        }

        // 10
        public override global::Skm.Holo.Vector3[] Vertices
        {
            get
            {
                return _Vertices.Value;
            }
            set
            {
                _Vertices.Value = value;
            }
        }

        // 11
        public override global::Skm.Holo.Color[] Colors32
        {
            get
            {
                return _Colors32.Value;
            }
            set
            {
                _Colors32.Value = value;
            }
        }

        // 12
        public override int[] Triangles
        {
            get
            {
                return _Triangles.Value;
            }
            set
            {
                _Triangles.Value = value;
            }
        }

        // 13
        public override string MaterialId
        {
            get
            {
                return _MaterialId.Value;
            }
            set
            {
                _MaterialId.Value = value;
            }
        }

        // 14
        public override int ShaderId
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, int>(__originalBytes, 14, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, int>(__originalBytes, 14, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }


        public MeshObjectSegment(global::ZeroFormatter.DirtyTracker dirtyTracker, ArraySegment<byte> originalBytes)
        {
            var __array = originalBytes.Array;

            this.__originalBytes = originalBytes;
            this.__tracker = dirtyTracker = dirtyTracker.CreateChild();
            this.__binaryLastIndex = BinaryUtil.ReadInt32(ref __array, originalBytes.Offset + 4);

            this.__extraFixedBytes = ObjectSegmentHelper.CreateExtraFixedBytes(this.__binaryLastIndex, 14, __elementSizes);

            _Bounds = new CacheSegment<TTypeResolver, global::Skm.Holo.Bounds>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 2, __binaryLastIndex, __tracker));
            _Normals = new CacheSegment<TTypeResolver, global::Skm.Holo.Vector3[]>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 3, __binaryLastIndex, __tracker));
            _Tangents = new CacheSegment<TTypeResolver, global::Skm.Holo.Vector4[]>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 4, __binaryLastIndex, __tracker));
            _Uv = new CacheSegment<TTypeResolver, global::Skm.Holo.Vector2[]>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 5, __binaryLastIndex, __tracker));
            _Uv2 = new CacheSegment<TTypeResolver, global::Skm.Holo.Vector2[]>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 6, __binaryLastIndex, __tracker));
            _Uv3 = new CacheSegment<TTypeResolver, global::Skm.Holo.Vector2[]>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 7, __binaryLastIndex, __tracker));
            _Uv4 = new CacheSegment<TTypeResolver, global::Skm.Holo.Vector2[]>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 8, __binaryLastIndex, __tracker));
            _Colors = new CacheSegment<TTypeResolver, global::Skm.Holo.Color[]>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 9, __binaryLastIndex, __tracker));
            _Vertices = new CacheSegment<TTypeResolver, global::Skm.Holo.Vector3[]>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 10, __binaryLastIndex, __tracker));
            _Colors32 = new CacheSegment<TTypeResolver, global::Skm.Holo.Color[]>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 11, __binaryLastIndex, __tracker));
            _Triangles = new CacheSegment<TTypeResolver, int[]>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 12, __binaryLastIndex, __tracker));
            _MaterialId = new CacheSegment<TTypeResolver, string>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 13, __binaryLastIndex, __tracker));
        }

        public bool CanDirectCopy()
        {
            return !__tracker.IsDirty;
        }

        public ArraySegment<byte> GetBufferReference()
        {
            return __originalBytes;
        }

        public int Serialize(ref byte[] targetBytes, int offset)
        {
            if (__extraFixedBytes != null || __tracker.IsDirty)
            {
                var startOffset = offset;
                offset += (8 + 4 * (14 + 1));

                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, int>(ref targetBytes, startOffset, offset, 1, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Bounds>(ref targetBytes, startOffset, offset, 2, ref _Bounds);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Vector3[]>(ref targetBytes, startOffset, offset, 3, ref _Normals);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Vector4[]>(ref targetBytes, startOffset, offset, 4, ref _Tangents);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Vector2[]>(ref targetBytes, startOffset, offset, 5, ref _Uv);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Vector2[]>(ref targetBytes, startOffset, offset, 6, ref _Uv2);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Vector2[]>(ref targetBytes, startOffset, offset, 7, ref _Uv3);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Vector2[]>(ref targetBytes, startOffset, offset, 8, ref _Uv4);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Color[]>(ref targetBytes, startOffset, offset, 9, ref _Colors);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Vector3[]>(ref targetBytes, startOffset, offset, 10, ref _Vertices);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Color[]>(ref targetBytes, startOffset, offset, 11, ref _Colors32);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, int[]>(ref targetBytes, startOffset, offset, 12, ref _Triangles);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, string>(ref targetBytes, startOffset, offset, 13, ref _MaterialId);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, int>(ref targetBytes, startOffset, offset, 14, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);

                return ObjectSegmentHelper.WriteSize(ref targetBytes, startOffset, offset, 14);
            }
            else
            {
                return ObjectSegmentHelper.DirectCopyAll(__originalBytes, ref targetBytes, offset);
            }
        }
    }

    public class MeshFilterFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.MeshFilter>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.MeshFilter value)
        {
            var segment = value as IZeroFormatterSegment;
            if (segment != null)
            {
                return segment.Serialize(ref bytes, offset);
            }
            else if (value == null)
            {
                BinaryUtil.WriteInt32(ref bytes, offset, -1);
                return 4;
            }
            else
            {
                var startOffset = offset;

                offset += (8 + 4 * (2 + 1));
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, string>(ref bytes, startOffset, offset, 0, value.Name);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::System.Guid>(ref bytes, startOffset, offset, 1, value.Guid);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.Mesh>>(ref bytes, startOffset, offset, 2, value.Meshes);

                return ObjectSegmentHelper.WriteSize(ref bytes, startOffset, offset, 2);
            }
        }

        public override global::Skm.Holo.MeshFilter Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = BinaryUtil.ReadInt32(ref bytes, offset);
            if (byteSize == -1)
            {
                byteSize = 4;
                return null;
            }
            return new MeshFilterObjectSegment<TTypeResolver>(tracker, new ArraySegment<byte>(bytes, offset, byteSize));
        }
    }

    public class MeshFilterObjectSegment<TTypeResolver> : global::Skm.Holo.MeshFilter, IZeroFormatterSegment
        where TTypeResolver : ITypeResolver, new()
    {
        static readonly int[] __elementSizes = new int[]{ 0, 16, 0 };

        readonly ArraySegment<byte> __originalBytes;
        readonly global::ZeroFormatter.DirtyTracker __tracker;
        readonly int __binaryLastIndex;
        readonly byte[] __extraFixedBytes;

        CacheSegment<TTypeResolver, string> _Name;
        CacheSegment<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.Mesh>> _Meshes;

        // 0
        public override string Name
        {
            get
            {
                return _Name.Value;
            }
            set
            {
                _Name.Value = value;
            }
        }

        // 1
        public override global::System.Guid Guid
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, global::System.Guid>(__originalBytes, 1, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, global::System.Guid>(__originalBytes, 1, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 2
        public override global::System.Collections.Generic.List<global::Skm.Holo.Mesh> Meshes
        {
            get
            {
                return _Meshes.Value;
            }
            set
            {
                _Meshes.Value = value;
            }
        }


        public MeshFilterObjectSegment(global::ZeroFormatter.DirtyTracker dirtyTracker, ArraySegment<byte> originalBytes)
        {
            var __array = originalBytes.Array;

            this.__originalBytes = originalBytes;
            this.__tracker = dirtyTracker = dirtyTracker.CreateChild();
            this.__binaryLastIndex = BinaryUtil.ReadInt32(ref __array, originalBytes.Offset + 4);

            this.__extraFixedBytes = ObjectSegmentHelper.CreateExtraFixedBytes(this.__binaryLastIndex, 2, __elementSizes);

            _Name = new CacheSegment<TTypeResolver, string>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 0, __binaryLastIndex, __tracker));
            _Meshes = new CacheSegment<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.Mesh>>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 2, __binaryLastIndex, __tracker));
        }

        public bool CanDirectCopy()
        {
            return !__tracker.IsDirty;
        }

        public ArraySegment<byte> GetBufferReference()
        {
            return __originalBytes;
        }

        public int Serialize(ref byte[] targetBytes, int offset)
        {
            if (__extraFixedBytes != null || __tracker.IsDirty)
            {
                var startOffset = offset;
                offset += (8 + 4 * (2 + 1));

                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, string>(ref targetBytes, startOffset, offset, 0, ref _Name);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, global::System.Guid>(ref targetBytes, startOffset, offset, 1, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.Mesh>>(ref targetBytes, startOffset, offset, 2, ref _Meshes);

                return ObjectSegmentHelper.WriteSize(ref targetBytes, startOffset, offset, 2);
            }
            else
            {
                return ObjectSegmentHelper.DirectCopyAll(__originalBytes, ref targetBytes, offset);
            }
        }
    }

    public class PointFilterFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.PointFilter>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.PointFilter value)
        {
            var segment = value as IZeroFormatterSegment;
            if (segment != null)
            {
                return segment.Serialize(ref bytes, offset);
            }
            else if (value == null)
            {
                BinaryUtil.WriteInt32(ref bytes, offset, -1);
                return 4;
            }
            else
            {
                var startOffset = offset;

                offset += (8 + 4 * (2 + 1));
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, string>(ref bytes, startOffset, offset, 0, value.Name);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::System.Guid>(ref bytes, startOffset, offset, 1, value.Guid);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Vector3[]>(ref bytes, startOffset, offset, 2, value.Points);

                return ObjectSegmentHelper.WriteSize(ref bytes, startOffset, offset, 2);
            }
        }

        public override global::Skm.Holo.PointFilter Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = BinaryUtil.ReadInt32(ref bytes, offset);
            if (byteSize == -1)
            {
                byteSize = 4;
                return null;
            }
            return new PointFilterObjectSegment<TTypeResolver>(tracker, new ArraySegment<byte>(bytes, offset, byteSize));
        }
    }

    public class PointFilterObjectSegment<TTypeResolver> : global::Skm.Holo.PointFilter, IZeroFormatterSegment
        where TTypeResolver : ITypeResolver, new()
    {
        static readonly int[] __elementSizes = new int[]{ 0, 16, 0 };

        readonly ArraySegment<byte> __originalBytes;
        readonly global::ZeroFormatter.DirtyTracker __tracker;
        readonly int __binaryLastIndex;
        readonly byte[] __extraFixedBytes;

        CacheSegment<TTypeResolver, string> _Name;
        CacheSegment<TTypeResolver, global::Skm.Holo.Vector3[]> _Points;

        // 0
        public override string Name
        {
            get
            {
                return _Name.Value;
            }
            set
            {
                _Name.Value = value;
            }
        }

        // 1
        public override global::System.Guid Guid
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, global::System.Guid>(__originalBytes, 1, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, global::System.Guid>(__originalBytes, 1, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 2
        public override global::Skm.Holo.Vector3[] Points
        {
            get
            {
                return _Points.Value;
            }
            set
            {
                _Points.Value = value;
            }
        }


        public PointFilterObjectSegment(global::ZeroFormatter.DirtyTracker dirtyTracker, ArraySegment<byte> originalBytes)
        {
            var __array = originalBytes.Array;

            this.__originalBytes = originalBytes;
            this.__tracker = dirtyTracker = dirtyTracker.CreateChild();
            this.__binaryLastIndex = BinaryUtil.ReadInt32(ref __array, originalBytes.Offset + 4);

            this.__extraFixedBytes = ObjectSegmentHelper.CreateExtraFixedBytes(this.__binaryLastIndex, 2, __elementSizes);

            _Name = new CacheSegment<TTypeResolver, string>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 0, __binaryLastIndex, __tracker));
            _Points = new CacheSegment<TTypeResolver, global::Skm.Holo.Vector3[]>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 2, __binaryLastIndex, __tracker));
        }

        public bool CanDirectCopy()
        {
            return !__tracker.IsDirty;
        }

        public ArraySegment<byte> GetBufferReference()
        {
            return __originalBytes;
        }

        public int Serialize(ref byte[] targetBytes, int offset)
        {
            if (__extraFixedBytes != null || __tracker.IsDirty)
            {
                var startOffset = offset;
                offset += (8 + 4 * (2 + 1));

                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, string>(ref targetBytes, startOffset, offset, 0, ref _Name);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, global::System.Guid>(ref targetBytes, startOffset, offset, 1, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Vector3[]>(ref targetBytes, startOffset, offset, 2, ref _Points);

                return ObjectSegmentHelper.WriteSize(ref targetBytes, startOffset, offset, 2);
            }
            else
            {
                return ObjectSegmentHelper.DirectCopyAll(__originalBytes, ref targetBytes, offset);
            }
        }
    }

    public class PropertyCollectionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.PropertyCollection>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.PropertyCollection value)
        {
            var segment = value as IZeroFormatterSegment;
            if (segment != null)
            {
                return segment.Serialize(ref bytes, offset);
            }
            else if (value == null)
            {
                BinaryUtil.WriteInt32(ref bytes, offset, -1);
                return 4;
            }
            else
            {
                var startOffset = offset;

                offset += (8 + 4 * (2 + 1));
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, string>(ref bytes, startOffset, offset, 0, value.Name);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::System.Guid>(ref bytes, startOffset, offset, 1, value.Guid);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::System.Collections.Generic.IDictionary<string, string>>(ref bytes, startOffset, offset, 2, value.Properties);

                return ObjectSegmentHelper.WriteSize(ref bytes, startOffset, offset, 2);
            }
        }

        public override global::Skm.Holo.PropertyCollection Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = BinaryUtil.ReadInt32(ref bytes, offset);
            if (byteSize == -1)
            {
                byteSize = 4;
                return null;
            }
            return new PropertyCollectionObjectSegment<TTypeResolver>(tracker, new ArraySegment<byte>(bytes, offset, byteSize));
        }
    }

    public class PropertyCollectionObjectSegment<TTypeResolver> : global::Skm.Holo.PropertyCollection, IZeroFormatterSegment
        where TTypeResolver : ITypeResolver, new()
    {
        static readonly int[] __elementSizes = new int[]{ 0, 16, 0 };

        readonly ArraySegment<byte> __originalBytes;
        readonly global::ZeroFormatter.DirtyTracker __tracker;
        readonly int __binaryLastIndex;
        readonly byte[] __extraFixedBytes;

        CacheSegment<TTypeResolver, string> _Name;
        CacheSegment<TTypeResolver, global::System.Collections.Generic.IDictionary<string, string>> _Properties;

        // 0
        public override string Name
        {
            get
            {
                return _Name.Value;
            }
            set
            {
                _Name.Value = value;
            }
        }

        // 1
        public override global::System.Guid Guid
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, global::System.Guid>(__originalBytes, 1, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, global::System.Guid>(__originalBytes, 1, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 2
        public override global::System.Collections.Generic.IDictionary<string, string> Properties
        {
            get
            {
                return _Properties.Value;
            }
            set
            {
                _Properties.Value = value;
            }
        }


        public PropertyCollectionObjectSegment(global::ZeroFormatter.DirtyTracker dirtyTracker, ArraySegment<byte> originalBytes)
        {
            var __array = originalBytes.Array;

            this.__originalBytes = originalBytes;
            this.__tracker = dirtyTracker = dirtyTracker.CreateChild();
            this.__binaryLastIndex = BinaryUtil.ReadInt32(ref __array, originalBytes.Offset + 4);

            this.__extraFixedBytes = ObjectSegmentHelper.CreateExtraFixedBytes(this.__binaryLastIndex, 2, __elementSizes);

            _Name = new CacheSegment<TTypeResolver, string>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 0, __binaryLastIndex, __tracker));
            _Properties = new CacheSegment<TTypeResolver, global::System.Collections.Generic.IDictionary<string, string>>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 2, __binaryLastIndex, __tracker));
        }

        public bool CanDirectCopy()
        {
            return !__tracker.IsDirty;
        }

        public ArraySegment<byte> GetBufferReference()
        {
            return __originalBytes;
        }

        public int Serialize(ref byte[] targetBytes, int offset)
        {
            if (__extraFixedBytes != null || __tracker.IsDirty)
            {
                var startOffset = offset;
                offset += (8 + 4 * (2 + 1));

                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, string>(ref targetBytes, startOffset, offset, 0, ref _Name);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, global::System.Guid>(ref targetBytes, startOffset, offset, 1, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::System.Collections.Generic.IDictionary<string, string>>(ref targetBytes, startOffset, offset, 2, ref _Properties);

                return ObjectSegmentHelper.WriteSize(ref targetBytes, startOffset, offset, 2);
            }
            else
            {
                return ObjectSegmentHelper.DirectCopyAll(__originalBytes, ref targetBytes, offset);
            }
        }
    }

    public class TransformFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.Transform>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.Transform value)
        {
            var segment = value as IZeroFormatterSegment;
            if (segment != null)
            {
                return segment.Serialize(ref bytes, offset);
            }
            else if (value == null)
            {
                BinaryUtil.WriteInt32(ref bytes, offset, -1);
                return 4;
            }
            else
            {
                var startOffset = offset;

                offset += (8 + 4 * (2 + 1));
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, string>(ref bytes, startOffset, offset, 0, value.Name);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::System.Guid>(ref bytes, startOffset, offset, 1, value.Guid);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Matrix4x4>(ref bytes, startOffset, offset, 2, value._LocalMatrix);

                return ObjectSegmentHelper.WriteSize(ref bytes, startOffset, offset, 2);
            }
        }

        public override global::Skm.Holo.Transform Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = BinaryUtil.ReadInt32(ref bytes, offset);
            if (byteSize == -1)
            {
                byteSize = 4;
                return null;
            }
            return new TransformObjectSegment<TTypeResolver>(tracker, new ArraySegment<byte>(bytes, offset, byteSize));
        }
    }

    public class TransformObjectSegment<TTypeResolver> : global::Skm.Holo.Transform, IZeroFormatterSegment
        where TTypeResolver : ITypeResolver, new()
    {
        static readonly int[] __elementSizes = new int[]{ 0, 16, 0 };

        readonly ArraySegment<byte> __originalBytes;
        readonly global::ZeroFormatter.DirtyTracker __tracker;
        readonly int __binaryLastIndex;
        readonly byte[] __extraFixedBytes;

        CacheSegment<TTypeResolver, string> _Name;
        CacheSegment<TTypeResolver, global::Skm.Holo.Matrix4x4> __LocalMatrix;

        // 0
        public override string Name
        {
            get
            {
                return _Name.Value;
            }
            set
            {
                _Name.Value = value;
            }
        }

        // 1
        public override global::System.Guid Guid
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, global::System.Guid>(__originalBytes, 1, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, global::System.Guid>(__originalBytes, 1, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 2
        public override global::Skm.Holo.Matrix4x4 _LocalMatrix
        {
            get
            {
                return __LocalMatrix.Value;
            }
            set
            {
                __LocalMatrix.Value = value;
            }
        }


        public TransformObjectSegment(global::ZeroFormatter.DirtyTracker dirtyTracker, ArraySegment<byte> originalBytes)
        {
            var __array = originalBytes.Array;

            this.__originalBytes = originalBytes;
            this.__tracker = dirtyTracker = dirtyTracker.CreateChild();
            this.__binaryLastIndex = BinaryUtil.ReadInt32(ref __array, originalBytes.Offset + 4);

            this.__extraFixedBytes = ObjectSegmentHelper.CreateExtraFixedBytes(this.__binaryLastIndex, 2, __elementSizes);

            _Name = new CacheSegment<TTypeResolver, string>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 0, __binaryLastIndex, __tracker));
            __LocalMatrix = new CacheSegment<TTypeResolver, global::Skm.Holo.Matrix4x4>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 2, __binaryLastIndex, __tracker));
        }

        public bool CanDirectCopy()
        {
            return !__tracker.IsDirty;
        }

        public ArraySegment<byte> GetBufferReference()
        {
            return __originalBytes;
        }

        public int Serialize(ref byte[] targetBytes, int offset)
        {
            if (__extraFixedBytes != null || __tracker.IsDirty)
            {
                var startOffset = offset;
                offset += (8 + 4 * (2 + 1));

                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, string>(ref targetBytes, startOffset, offset, 0, ref _Name);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, global::System.Guid>(ref targetBytes, startOffset, offset, 1, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Matrix4x4>(ref targetBytes, startOffset, offset, 2, ref __LocalMatrix);

                return ObjectSegmentHelper.WriteSize(ref targetBytes, startOffset, offset, 2);
            }
            else
            {
                return ObjectSegmentHelper.DirectCopyAll(__originalBytes, ref targetBytes, offset);
            }
        }
    }

    public class SmobPreferencesFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.SmobPreferences>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.SmobPreferences value)
        {
            var segment = value as IZeroFormatterSegment;
            if (segment != null)
            {
                return segment.Serialize(ref bytes, offset);
            }
            else if (value == null)
            {
                BinaryUtil.WriteInt32(ref bytes, offset, -1);
                return 4;
            }
            else
            {
                var startOffset = offset;

                offset += (8 + 4 * (8 + 1));
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::System.Collections.Generic.IList<global::Skm.Holo.Light>>(ref bytes, startOffset, offset, 0, value.Lights);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Color>(ref bytes, startOffset, offset, 1, value.WireframeColor);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Color>(ref bytes, startOffset, offset, 2, value.DefaultColor);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.Transform>(ref bytes, startOffset, offset, 3, value.CameraTransform);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 4, value.CameraFov);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 5, value.CameraWidth);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, bool>(ref bytes, startOffset, offset, 6, value.CameraOrthographic);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, string>(ref bytes, startOffset, offset, 7, value.GeoAlignment);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, string>(ref bytes, startOffset, offset, 8, value.GeoAlignmentJson);

                return ObjectSegmentHelper.WriteSize(ref bytes, startOffset, offset, 8);
            }
        }

        public override global::Skm.Holo.SmobPreferences Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = BinaryUtil.ReadInt32(ref bytes, offset);
            if (byteSize == -1)
            {
                byteSize = 4;
                return null;
            }
            return new SmobPreferencesObjectSegment<TTypeResolver>(tracker, new ArraySegment<byte>(bytes, offset, byteSize));
        }
    }

    public class SmobPreferencesObjectSegment<TTypeResolver> : global::Skm.Holo.SmobPreferences, IZeroFormatterSegment
        where TTypeResolver : ITypeResolver, new()
    {
        static readonly int[] __elementSizes = new int[]{ 0, 0, 0, 0, 4, 4, 1, 0, 0 };

        readonly ArraySegment<byte> __originalBytes;
        readonly global::ZeroFormatter.DirtyTracker __tracker;
        readonly int __binaryLastIndex;
        readonly byte[] __extraFixedBytes;

        global::System.Collections.Generic.IList<global::Skm.Holo.Light> _Lights;
        CacheSegment<TTypeResolver, global::Skm.Holo.Color> _WireframeColor;
        CacheSegment<TTypeResolver, global::Skm.Holo.Color> _DefaultColor;
        global::Skm.Holo.Transform _CameraTransform;
        CacheSegment<TTypeResolver, string> _GeoAlignment;
        CacheSegment<TTypeResolver, string> _GeoAlignmentJson;

        // 0
        public override global::System.Collections.Generic.IList<global::Skm.Holo.Light> Lights
        {
            get
            {
                return _Lights;
            }
            set
            {
                __tracker.Dirty();
                _Lights = value;
            }
        }

        // 1
        public override global::Skm.Holo.Color WireframeColor
        {
            get
            {
                return _WireframeColor.Value;
            }
            set
            {
                _WireframeColor.Value = value;
            }
        }

        // 2
        public override global::Skm.Holo.Color DefaultColor
        {
            get
            {
                return _DefaultColor.Value;
            }
            set
            {
                _DefaultColor.Value = value;
            }
        }

        // 3
        public override global::Skm.Holo.Transform CameraTransform
        {
            get
            {
                return _CameraTransform;
            }
            set
            {
                __tracker.Dirty();
                _CameraTransform = value;
            }
        }

        // 4
        public override float CameraFov
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 4, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 4, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 5
        public override float CameraWidth
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 5, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 5, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 6
        public override bool CameraOrthographic
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, bool>(__originalBytes, 6, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, bool>(__originalBytes, 6, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 7
        public override string GeoAlignment
        {
            get
            {
                return _GeoAlignment.Value;
            }
            set
            {
                _GeoAlignment.Value = value;
            }
        }

        // 8
        public override string GeoAlignmentJson
        {
            get
            {
                return _GeoAlignmentJson.Value;
            }
            set
            {
                _GeoAlignmentJson.Value = value;
            }
        }


        public SmobPreferencesObjectSegment(global::ZeroFormatter.DirtyTracker dirtyTracker, ArraySegment<byte> originalBytes)
        {
            var __array = originalBytes.Array;

            this.__originalBytes = originalBytes;
            this.__tracker = dirtyTracker = dirtyTracker.CreateChild();
            this.__binaryLastIndex = BinaryUtil.ReadInt32(ref __array, originalBytes.Offset + 4);

            this.__extraFixedBytes = ObjectSegmentHelper.CreateExtraFixedBytes(this.__binaryLastIndex, 8, __elementSizes);

            _Lights = ObjectSegmentHelper.DeserializeSegment<TTypeResolver, global::System.Collections.Generic.IList<global::Skm.Holo.Light>>(originalBytes, 0, __binaryLastIndex, __tracker);
            _WireframeColor = new CacheSegment<TTypeResolver, global::Skm.Holo.Color>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 1, __binaryLastIndex, __tracker));
            _DefaultColor = new CacheSegment<TTypeResolver, global::Skm.Holo.Color>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 2, __binaryLastIndex, __tracker));
            _CameraTransform = ObjectSegmentHelper.DeserializeSegment<TTypeResolver, global::Skm.Holo.Transform>(originalBytes, 3, __binaryLastIndex, __tracker);
            _GeoAlignment = new CacheSegment<TTypeResolver, string>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 7, __binaryLastIndex, __tracker));
            _GeoAlignmentJson = new CacheSegment<TTypeResolver, string>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 8, __binaryLastIndex, __tracker));
        }

        public bool CanDirectCopy()
        {
            return !__tracker.IsDirty;
        }

        public ArraySegment<byte> GetBufferReference()
        {
            return __originalBytes;
        }

        public int Serialize(ref byte[] targetBytes, int offset)
        {
            if (__extraFixedBytes != null || __tracker.IsDirty)
            {
                var startOffset = offset;
                offset += (8 + 4 * (8 + 1));

                offset += ObjectSegmentHelper.SerializeSegment<TTypeResolver, global::System.Collections.Generic.IList<global::Skm.Holo.Light>>(ref targetBytes, startOffset, offset, 0, _Lights);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Color>(ref targetBytes, startOffset, offset, 1, ref _WireframeColor);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::Skm.Holo.Color>(ref targetBytes, startOffset, offset, 2, ref _DefaultColor);
                offset += ObjectSegmentHelper.SerializeSegment<TTypeResolver, global::Skm.Holo.Transform>(ref targetBytes, startOffset, offset, 3, _CameraTransform);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 4, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 5, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, bool>(ref targetBytes, startOffset, offset, 6, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, string>(ref targetBytes, startOffset, offset, 7, ref _GeoAlignment);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, string>(ref targetBytes, startOffset, offset, 8, ref _GeoAlignmentJson);

                return ObjectSegmentHelper.WriteSize(ref targetBytes, startOffset, offset, 8);
            }
            else
            {
                return ObjectSegmentHelper.DirectCopyAll(__originalBytes, ref targetBytes, offset);
            }
        }
    }

    public class SKMMobileObjectFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.SKMMobileObject>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.SKMMobileObject value)
        {
            var segment = value as IZeroFormatterSegment;
            if (segment != null)
            {
                return segment.Serialize(ref bytes, offset);
            }
            else if (value == null)
            {
                BinaryUtil.WriteInt32(ref bytes, offset, -1);
                return 4;
            }
            else
            {
                var startOffset = offset;

                offset += (8 + 4 * (6 + 1));
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, string>(ref bytes, startOffset, offset, 0, value.Name);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.GameObject>>(ref bytes, startOffset, offset, 1, value._GameObjects);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.Material>>(ref bytes, startOffset, offset, 3, value.Materials);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.Component>>(ref bytes, startOffset, offset, 4, value.Geometries);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::Skm.Holo.SmobPreferences>(ref bytes, startOffset, offset, 6, value.Preferences);

                return ObjectSegmentHelper.WriteSize(ref bytes, startOffset, offset, 6);
            }
        }

        public override global::Skm.Holo.SKMMobileObject Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = BinaryUtil.ReadInt32(ref bytes, offset);
            if (byteSize == -1)
            {
                byteSize = 4;
                return null;
            }
            return new SKMMobileObjectObjectSegment<TTypeResolver>(tracker, new ArraySegment<byte>(bytes, offset, byteSize));
        }
    }

    public class SKMMobileObjectObjectSegment<TTypeResolver> : global::Skm.Holo.SKMMobileObject, IZeroFormatterSegment
        where TTypeResolver : ITypeResolver, new()
    {
        static readonly int[] __elementSizes = new int[]{ 0, 0, 0, 0, 0, 0, 0 };

        readonly ArraySegment<byte> __originalBytes;
        readonly global::ZeroFormatter.DirtyTracker __tracker;
        readonly int __binaryLastIndex;
        readonly byte[] __extraFixedBytes;

        CacheSegment<TTypeResolver, string> _Name;
        CacheSegment<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.GameObject>> __GameObjects;
        CacheSegment<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.Material>> _Materials;
        CacheSegment<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.Component>> _Geometries;
        global::Skm.Holo.SmobPreferences _Preferences;

        // 0
        public override string Name
        {
            get
            {
                return _Name.Value;
            }
            set
            {
                _Name.Value = value;
            }
        }

        // 1
        public override global::System.Collections.Generic.List<global::Skm.Holo.GameObject> _GameObjects
        {
            get
            {
                return __GameObjects.Value;
            }
            set
            {
                __GameObjects.Value = value;
            }
        }

        // 3
        public override global::System.Collections.Generic.List<global::Skm.Holo.Material> Materials
        {
            get
            {
                return _Materials.Value;
            }
            set
            {
                _Materials.Value = value;
            }
        }

        // 4
        public override global::System.Collections.Generic.List<global::Skm.Holo.Component> Geometries
        {
            get
            {
                return _Geometries.Value;
            }
            set
            {
                _Geometries.Value = value;
            }
        }

        // 6
        public override global::Skm.Holo.SmobPreferences Preferences
        {
            get
            {
                return _Preferences;
            }
            set
            {
                __tracker.Dirty();
                _Preferences = value;
            }
        }


        public SKMMobileObjectObjectSegment(global::ZeroFormatter.DirtyTracker dirtyTracker, ArraySegment<byte> originalBytes)
        {
            var __array = originalBytes.Array;

            this.__originalBytes = originalBytes;
            this.__tracker = dirtyTracker = dirtyTracker.CreateChild();
            this.__binaryLastIndex = BinaryUtil.ReadInt32(ref __array, originalBytes.Offset + 4);

            this.__extraFixedBytes = ObjectSegmentHelper.CreateExtraFixedBytes(this.__binaryLastIndex, 6, __elementSizes);

            _Name = new CacheSegment<TTypeResolver, string>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 0, __binaryLastIndex, __tracker));
            __GameObjects = new CacheSegment<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.GameObject>>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 1, __binaryLastIndex, __tracker));
            _Materials = new CacheSegment<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.Material>>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 3, __binaryLastIndex, __tracker));
            _Geometries = new CacheSegment<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.Component>>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 4, __binaryLastIndex, __tracker));
            _Preferences = ObjectSegmentHelper.DeserializeSegment<TTypeResolver, global::Skm.Holo.SmobPreferences>(originalBytes, 6, __binaryLastIndex, __tracker);
        }

        public bool CanDirectCopy()
        {
            return !__tracker.IsDirty;
        }

        public ArraySegment<byte> GetBufferReference()
        {
            return __originalBytes;
        }

        public int Serialize(ref byte[] targetBytes, int offset)
        {
            if (__extraFixedBytes != null || __tracker.IsDirty)
            {
                var startOffset = offset;
                offset += (8 + 4 * (6 + 1));

                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, string>(ref targetBytes, startOffset, offset, 0, ref _Name);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.GameObject>>(ref targetBytes, startOffset, offset, 1, ref __GameObjects);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.Material>>(ref targetBytes, startOffset, offset, 3, ref _Materials);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, global::System.Collections.Generic.List<global::Skm.Holo.Component>>(ref targetBytes, startOffset, offset, 4, ref _Geometries);
                offset += ObjectSegmentHelper.SerializeSegment<TTypeResolver, global::Skm.Holo.SmobPreferences>(ref targetBytes, startOffset, offset, 6, _Preferences);

                return ObjectSegmentHelper.WriteSize(ref targetBytes, startOffset, offset, 6);
            }
            else
            {
                return ObjectSegmentHelper.DirectCopyAll(__originalBytes, ref targetBytes, offset);
            }
        }
    }


}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
namespace ZeroFormatter.DynamicObjectSegments.Skm.Holo
{
    using global::System;
    using global::ZeroFormatter.Formatters;
    using global::ZeroFormatter.Internal;
    using global::ZeroFormatter.Segments;

    public class KeyframeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.Keyframe>
        where TTypeResolver : ITypeResolver, new()
    {
        readonly Formatter<TTypeResolver, float> formatter0;
        readonly Formatter<TTypeResolver, float> formatter1;
        
        public override bool NoUseDirtyTracker
        {
            get
            {
                return formatter0.NoUseDirtyTracker
                    && formatter1.NoUseDirtyTracker
                ;
            }
        }

        public KeyframeFormatter()
        {
            formatter0 = Formatter<TTypeResolver, float>.Default;
            formatter1 = Formatter<TTypeResolver, float>.Default;
            
        }

        public override int? GetLength()
        {
            return 8;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.Keyframe value)
        {
            BinaryUtil.EnsureCapacity(ref bytes, offset, 8);
            var startOffset = offset;
            offset += formatter0.Serialize(ref bytes, offset, value.Time);
            offset += formatter1.Serialize(ref bytes, offset, value.Value);
            return offset - startOffset;
        }

        public override global::Skm.Holo.Keyframe Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 0;
            int size;
            var item0 = formatter0.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item1 = formatter1.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            
            return new global::Skm.Holo.Keyframe(item0, item1);
        }
    }

    public class ColorFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.Color>
        where TTypeResolver : ITypeResolver, new()
    {
        readonly Formatter<TTypeResolver, float> formatter0;
        readonly Formatter<TTypeResolver, float> formatter1;
        readonly Formatter<TTypeResolver, float> formatter2;
        readonly Formatter<TTypeResolver, float> formatter3;
        
        public override bool NoUseDirtyTracker
        {
            get
            {
                return formatter0.NoUseDirtyTracker
                    && formatter1.NoUseDirtyTracker
                    && formatter2.NoUseDirtyTracker
                    && formatter3.NoUseDirtyTracker
                ;
            }
        }

        public ColorFormatter()
        {
            formatter0 = Formatter<TTypeResolver, float>.Default;
            formatter1 = Formatter<TTypeResolver, float>.Default;
            formatter2 = Formatter<TTypeResolver, float>.Default;
            formatter3 = Formatter<TTypeResolver, float>.Default;
            
        }

        public override int? GetLength()
        {
            return 16;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.Color value)
        {
            BinaryUtil.EnsureCapacity(ref bytes, offset, 16);
            var startOffset = offset;
            offset += formatter0.Serialize(ref bytes, offset, value.r);
            offset += formatter1.Serialize(ref bytes, offset, value.g);
            offset += formatter2.Serialize(ref bytes, offset, value.b);
            offset += formatter3.Serialize(ref bytes, offset, value.a);
            return offset - startOffset;
        }

        public override global::Skm.Holo.Color Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 0;
            int size;
            var item0 = formatter0.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item1 = formatter1.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item2 = formatter2.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item3 = formatter3.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            
            return new global::Skm.Holo.Color(item0, item1, item2, item3);
        }
    }

    public class Vector3Formatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.Vector3>
        where TTypeResolver : ITypeResolver, new()
    {
        readonly Formatter<TTypeResolver, float> formatter0;
        readonly Formatter<TTypeResolver, float> formatter1;
        readonly Formatter<TTypeResolver, float> formatter2;
        
        public override bool NoUseDirtyTracker
        {
            get
            {
                return formatter0.NoUseDirtyTracker
                    && formatter1.NoUseDirtyTracker
                    && formatter2.NoUseDirtyTracker
                ;
            }
        }

        public Vector3Formatter()
        {
            formatter0 = Formatter<TTypeResolver, float>.Default;
            formatter1 = Formatter<TTypeResolver, float>.Default;
            formatter2 = Formatter<TTypeResolver, float>.Default;
            
        }

        public override int? GetLength()
        {
            return 12;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.Vector3 value)
        {
            BinaryUtil.EnsureCapacity(ref bytes, offset, 12);
            var startOffset = offset;
            offset += formatter0.Serialize(ref bytes, offset, value.x);
            offset += formatter1.Serialize(ref bytes, offset, value.y);
            offset += formatter2.Serialize(ref bytes, offset, value.z);
            return offset - startOffset;
        }

        public override global::Skm.Holo.Vector3 Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 0;
            int size;
            var item0 = formatter0.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item1 = formatter1.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item2 = formatter2.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            
            return new global::Skm.Holo.Vector3(item0, item1, item2);
        }
    }

    public class BoundsFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.Bounds>
        where TTypeResolver : ITypeResolver, new()
    {
        readonly Formatter<TTypeResolver, global::Skm.Holo.Vector3> formatter0;
        readonly Formatter<TTypeResolver, global::Skm.Holo.Vector3> formatter1;
        
        public override bool NoUseDirtyTracker
        {
            get
            {
                return formatter0.NoUseDirtyTracker
                    && formatter1.NoUseDirtyTracker
                ;
            }
        }

        public BoundsFormatter()
        {
            formatter0 = Formatter<TTypeResolver, global::Skm.Holo.Vector3>.Default;
            formatter1 = Formatter<TTypeResolver, global::Skm.Holo.Vector3>.Default;
            
        }

        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.Bounds value)
        {
            var startOffset = offset;
            offset += formatter0.Serialize(ref bytes, offset, value.Extents);
            offset += formatter1.Serialize(ref bytes, offset, value.Center);
            return offset - startOffset;
        }

        public override global::Skm.Holo.Bounds Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 0;
            int size;
            var item0 = formatter0.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item1 = formatter1.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            
            return new global::Skm.Holo.Bounds(item0, item1);
        }
    }

    public class Vector4Formatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.Vector4>
        where TTypeResolver : ITypeResolver, new()
    {
        readonly Formatter<TTypeResolver, float> formatter0;
        readonly Formatter<TTypeResolver, float> formatter1;
        readonly Formatter<TTypeResolver, float> formatter2;
        readonly Formatter<TTypeResolver, float> formatter3;
        
        public override bool NoUseDirtyTracker
        {
            get
            {
                return formatter0.NoUseDirtyTracker
                    && formatter1.NoUseDirtyTracker
                    && formatter2.NoUseDirtyTracker
                    && formatter3.NoUseDirtyTracker
                ;
            }
        }

        public Vector4Formatter()
        {
            formatter0 = Formatter<TTypeResolver, float>.Default;
            formatter1 = Formatter<TTypeResolver, float>.Default;
            formatter2 = Formatter<TTypeResolver, float>.Default;
            formatter3 = Formatter<TTypeResolver, float>.Default;
            
        }

        public override int? GetLength()
        {
            return 16;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.Vector4 value)
        {
            BinaryUtil.EnsureCapacity(ref bytes, offset, 16);
            var startOffset = offset;
            offset += formatter0.Serialize(ref bytes, offset, value.x);
            offset += formatter1.Serialize(ref bytes, offset, value.y);
            offset += formatter2.Serialize(ref bytes, offset, value.z);
            offset += formatter3.Serialize(ref bytes, offset, value.w);
            return offset - startOffset;
        }

        public override global::Skm.Holo.Vector4 Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 0;
            int size;
            var item0 = formatter0.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item1 = formatter1.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item2 = formatter2.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item3 = formatter3.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            
            return new global::Skm.Holo.Vector4(item0, item1, item2, item3);
        }
    }

    public class Vector2Formatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.Vector2>
        where TTypeResolver : ITypeResolver, new()
    {
        readonly Formatter<TTypeResolver, float> formatter0;
        readonly Formatter<TTypeResolver, float> formatter1;
        
        public override bool NoUseDirtyTracker
        {
            get
            {
                return formatter0.NoUseDirtyTracker
                    && formatter1.NoUseDirtyTracker
                ;
            }
        }

        public Vector2Formatter()
        {
            formatter0 = Formatter<TTypeResolver, float>.Default;
            formatter1 = Formatter<TTypeResolver, float>.Default;
            
        }

        public override int? GetLength()
        {
            return 8;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.Vector2 value)
        {
            BinaryUtil.EnsureCapacity(ref bytes, offset, 8);
            var startOffset = offset;
            offset += formatter0.Serialize(ref bytes, offset, value.x);
            offset += formatter1.Serialize(ref bytes, offset, value.y);
            return offset - startOffset;
        }

        public override global::Skm.Holo.Vector2 Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 0;
            int size;
            var item0 = formatter0.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item1 = formatter1.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            
            return new global::Skm.Holo.Vector2(item0, item1);
        }
    }

    public class Matrix4x4Formatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.Matrix4x4>
        where TTypeResolver : ITypeResolver, new()
    {
        readonly Formatter<TTypeResolver, float> formatter0;
        readonly Formatter<TTypeResolver, float> formatter1;
        readonly Formatter<TTypeResolver, float> formatter2;
        readonly Formatter<TTypeResolver, float> formatter3;
        readonly Formatter<TTypeResolver, float> formatter4;
        readonly Formatter<TTypeResolver, float> formatter5;
        readonly Formatter<TTypeResolver, float> formatter6;
        readonly Formatter<TTypeResolver, float> formatter7;
        readonly Formatter<TTypeResolver, float> formatter8;
        readonly Formatter<TTypeResolver, float> formatter9;
        readonly Formatter<TTypeResolver, float> formatter10;
        readonly Formatter<TTypeResolver, float> formatter11;
        readonly Formatter<TTypeResolver, float> formatter12;
        readonly Formatter<TTypeResolver, float> formatter13;
        readonly Formatter<TTypeResolver, float> formatter14;
        readonly Formatter<TTypeResolver, float> formatter15;
        
        public override bool NoUseDirtyTracker
        {
            get
            {
                return formatter0.NoUseDirtyTracker
                    && formatter1.NoUseDirtyTracker
                    && formatter2.NoUseDirtyTracker
                    && formatter3.NoUseDirtyTracker
                    && formatter4.NoUseDirtyTracker
                    && formatter5.NoUseDirtyTracker
                    && formatter6.NoUseDirtyTracker
                    && formatter7.NoUseDirtyTracker
                    && formatter8.NoUseDirtyTracker
                    && formatter9.NoUseDirtyTracker
                    && formatter10.NoUseDirtyTracker
                    && formatter11.NoUseDirtyTracker
                    && formatter12.NoUseDirtyTracker
                    && formatter13.NoUseDirtyTracker
                    && formatter14.NoUseDirtyTracker
                    && formatter15.NoUseDirtyTracker
                ;
            }
        }

        public Matrix4x4Formatter()
        {
            formatter0 = Formatter<TTypeResolver, float>.Default;
            formatter1 = Formatter<TTypeResolver, float>.Default;
            formatter2 = Formatter<TTypeResolver, float>.Default;
            formatter3 = Formatter<TTypeResolver, float>.Default;
            formatter4 = Formatter<TTypeResolver, float>.Default;
            formatter5 = Formatter<TTypeResolver, float>.Default;
            formatter6 = Formatter<TTypeResolver, float>.Default;
            formatter7 = Formatter<TTypeResolver, float>.Default;
            formatter8 = Formatter<TTypeResolver, float>.Default;
            formatter9 = Formatter<TTypeResolver, float>.Default;
            formatter10 = Formatter<TTypeResolver, float>.Default;
            formatter11 = Formatter<TTypeResolver, float>.Default;
            formatter12 = Formatter<TTypeResolver, float>.Default;
            formatter13 = Formatter<TTypeResolver, float>.Default;
            formatter14 = Formatter<TTypeResolver, float>.Default;
            formatter15 = Formatter<TTypeResolver, float>.Default;
            
        }

        public override int? GetLength()
        {
            return 64;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.Matrix4x4 value)
        {
            BinaryUtil.EnsureCapacity(ref bytes, offset, 64);
            var startOffset = offset;
            offset += formatter0.Serialize(ref bytes, offset, value.m00);
            offset += formatter1.Serialize(ref bytes, offset, value.m10);
            offset += formatter2.Serialize(ref bytes, offset, value.m20);
            offset += formatter3.Serialize(ref bytes, offset, value.m30);
            offset += formatter4.Serialize(ref bytes, offset, value.m01);
            offset += formatter5.Serialize(ref bytes, offset, value.m11);
            offset += formatter6.Serialize(ref bytes, offset, value.m21);
            offset += formatter7.Serialize(ref bytes, offset, value.m31);
            offset += formatter8.Serialize(ref bytes, offset, value.m02);
            offset += formatter9.Serialize(ref bytes, offset, value.m12);
            offset += formatter10.Serialize(ref bytes, offset, value.m22);
            offset += formatter11.Serialize(ref bytes, offset, value.m32);
            offset += formatter12.Serialize(ref bytes, offset, value.m03);
            offset += formatter13.Serialize(ref bytes, offset, value.m13);
            offset += formatter14.Serialize(ref bytes, offset, value.m23);
            offset += formatter15.Serialize(ref bytes, offset, value.m33);
            return offset - startOffset;
        }

        public override global::Skm.Holo.Matrix4x4 Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 0;
            int size;
            var item0 = formatter0.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item1 = formatter1.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item2 = formatter2.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item3 = formatter3.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item4 = formatter4.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item5 = formatter5.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item6 = formatter6.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item7 = formatter7.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item8 = formatter8.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item9 = formatter9.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item10 = formatter10.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item11 = formatter11.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item12 = formatter12.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item13 = formatter13.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item14 = formatter14.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item15 = formatter15.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            
            return new global::Skm.Holo.Matrix4x4(item0, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15);
        }
    }

    public class QuaternionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.Quaternion>
        where TTypeResolver : ITypeResolver, new()
    {
        readonly Formatter<TTypeResolver, float> formatter0;
        readonly Formatter<TTypeResolver, float> formatter1;
        readonly Formatter<TTypeResolver, float> formatter2;
        readonly Formatter<TTypeResolver, float> formatter3;
        
        public override bool NoUseDirtyTracker
        {
            get
            {
                return formatter0.NoUseDirtyTracker
                    && formatter1.NoUseDirtyTracker
                    && formatter2.NoUseDirtyTracker
                    && formatter3.NoUseDirtyTracker
                ;
            }
        }

        public QuaternionFormatter()
        {
            formatter0 = Formatter<TTypeResolver, float>.Default;
            formatter1 = Formatter<TTypeResolver, float>.Default;
            formatter2 = Formatter<TTypeResolver, float>.Default;
            formatter3 = Formatter<TTypeResolver, float>.Default;
            
        }

        public override int? GetLength()
        {
            return 16;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.Quaternion value)
        {
            BinaryUtil.EnsureCapacity(ref bytes, offset, 16);
            var startOffset = offset;
            offset += formatter0.Serialize(ref bytes, offset, value.x);
            offset += formatter1.Serialize(ref bytes, offset, value.y);
            offset += formatter2.Serialize(ref bytes, offset, value.z);
            offset += formatter3.Serialize(ref bytes, offset, value.w);
            return offset - startOffset;
        }

        public override global::Skm.Holo.Quaternion Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 0;
            int size;
            var item0 = formatter0.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item1 = formatter1.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item2 = formatter2.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item3 = formatter3.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            
            return new global::Skm.Holo.Quaternion(item0, item1, item2, item3);
        }
    }


}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
namespace ZeroFormatter.DynamicObjectSegments.Skm.Holo
{
    using global::System;
    using global::ZeroFormatter.Formatters;
    using global::ZeroFormatter.Internal;
    using global::ZeroFormatter.Segments;

    public class ComponentFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.Component>
        where TTypeResolver : ITypeResolver, new()
    {
        readonly global::System.Collections.Generic.IEqualityComparer<int> comparer;
        readonly int[] unionKeys;
        
        public ComponentFormatter()
        {
            comparer = global::ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<int>.Default;
            unionKeys = new int[6];
            unionKeys[0] = new global::Skm.Holo.MeshFilter().Type;
            unionKeys[1] = new global::Skm.Holo.Transform().Type;
            unionKeys[2] = new global::Skm.Holo.PropertyCollection().Type;
            unionKeys[3] = new global::Skm.Holo.LineFilter().Type;
            unionKeys[4] = new global::Skm.Holo.Animation().Type;
            unionKeys[5] = new global::Skm.Holo.PointFilter().Type;
            
        }

        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.Component value)
        {
            if (value == null)
            {
                return BinaryUtil.WriteInt32(ref bytes, offset, -1);
            }

            var startOffset = offset;

            offset += 4;
            offset += Formatter<TTypeResolver, int>.Default.Serialize(ref bytes, offset, value.Type);

            if (value is global::Skm.Holo.MeshFilter)
            {
                offset += Formatter<TTypeResolver, global::Skm.Holo.MeshFilter>.Default.Serialize(ref bytes, offset, (global::Skm.Holo.MeshFilter)value);
            }
            else if (value is global::Skm.Holo.Transform)
            {
                offset += Formatter<TTypeResolver, global::Skm.Holo.Transform>.Default.Serialize(ref bytes, offset, (global::Skm.Holo.Transform)value);
            }
            else if (value is global::Skm.Holo.PropertyCollection)
            {
                offset += Formatter<TTypeResolver, global::Skm.Holo.PropertyCollection>.Default.Serialize(ref bytes, offset, (global::Skm.Holo.PropertyCollection)value);
            }
            else if (value is global::Skm.Holo.LineFilter)
            {
                offset += Formatter<TTypeResolver, global::Skm.Holo.LineFilter>.Default.Serialize(ref bytes, offset, (global::Skm.Holo.LineFilter)value);
            }
            else if (value is global::Skm.Holo.Animation)
            {
                offset += Formatter<TTypeResolver, global::Skm.Holo.Animation>.Default.Serialize(ref bytes, offset, (global::Skm.Holo.Animation)value);
            }
            else if (value is global::Skm.Holo.PointFilter)
            {
                offset += Formatter<TTypeResolver, global::Skm.Holo.PointFilter>.Default.Serialize(ref bytes, offset, (global::Skm.Holo.PointFilter)value);
            }
            
            else
            {
                throw new Exception("Unknown subtype of Union:" + value.GetType().FullName);
            }
        
            var writeSize = offset - startOffset;
            BinaryUtil.WriteInt32(ref bytes, startOffset, writeSize);
            return writeSize;
        }

        public override global::Skm.Holo.Component Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            if ((byteSize = BinaryUtil.ReadInt32(ref bytes, offset)) == -1)
            {
                byteSize = 4;
                return null;
            }
        
            offset += 4;
            int size;
            var unionKey = Formatter<TTypeResolver, int>.Default.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;

            global::Skm.Holo.Component result;
            if (comparer.Equals(unionKey, unionKeys[0]))
            {
                result = Formatter<TTypeResolver, global::Skm.Holo.MeshFilter>.Default.Deserialize(ref bytes, offset, tracker, out size);
            }
            else if (comparer.Equals(unionKey, unionKeys[1]))
            {
                result = Formatter<TTypeResolver, global::Skm.Holo.Transform>.Default.Deserialize(ref bytes, offset, tracker, out size);
            }
            else if (comparer.Equals(unionKey, unionKeys[2]))
            {
                result = Formatter<TTypeResolver, global::Skm.Holo.PropertyCollection>.Default.Deserialize(ref bytes, offset, tracker, out size);
            }
            else if (comparer.Equals(unionKey, unionKeys[3]))
            {
                result = Formatter<TTypeResolver, global::Skm.Holo.LineFilter>.Default.Deserialize(ref bytes, offset, tracker, out size);
            }
            else if (comparer.Equals(unionKey, unionKeys[4]))
            {
                result = Formatter<TTypeResolver, global::Skm.Holo.Animation>.Default.Deserialize(ref bytes, offset, tracker, out size);
            }
            else if (comparer.Equals(unionKey, unionKeys[5]))
            {
                result = Formatter<TTypeResolver, global::Skm.Holo.PointFilter>.Default.Deserialize(ref bytes, offset, tracker, out size);
            }
            else
            {
                throw new Exception("Unknown unionKey type of Union: " + unionKey.ToString());
            }

            return result;
        }
    }


}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
namespace ZeroFormatter.DynamicObjectSegments.Skm.Holo
{
    using global::System;
    using global::System.Collections.Generic;
    using global::ZeroFormatter.Formatters;
    using global::ZeroFormatter.Internal;
    using global::ZeroFormatter.Segments;


    public class AnimationPathTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.AnimationPathType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.AnimationPathType value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Skm.Holo.AnimationPathType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Skm.Holo.AnimationPathType)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableAnimationPathTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.AnimationPathType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.AnimationPathType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Skm.Holo.AnimationPathType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Skm.Holo.AnimationPathType)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class AnimationPathTypeEqualityComparer : IEqualityComparer<global::Skm.Holo.AnimationPathType>
    {
        public bool Equals(global::Skm.Holo.AnimationPathType x, global::Skm.Holo.AnimationPathType y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Skm.Holo.AnimationPathType x)
        {
            return (int)x;
        }
    }



    public class ComponentTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.ComponentType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.ComponentType value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Skm.Holo.ComponentType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Skm.Holo.ComponentType)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableComponentTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.ComponentType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.ComponentType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Skm.Holo.ComponentType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Skm.Holo.ComponentType)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class ComponentTypeEqualityComparer : IEqualityComparer<global::Skm.Holo.ComponentType>
    {
        public bool Equals(global::Skm.Holo.ComponentType x, global::Skm.Holo.ComponentType y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Skm.Holo.ComponentType x)
        {
            return (int)x;
        }
    }



    public class FileHeader_KeysFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.FileHeader.Keys>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.FileHeader.Keys value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Skm.Holo.FileHeader.Keys Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Skm.Holo.FileHeader.Keys)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableFileHeader_KeysFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.FileHeader.Keys?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.FileHeader.Keys? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Skm.Holo.FileHeader.Keys? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Skm.Holo.FileHeader.Keys)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class FileHeader_KeysEqualityComparer : IEqualityComparer<global::Skm.Holo.FileHeader.Keys>
    {
        public bool Equals(global::Skm.Holo.FileHeader.Keys x, global::Skm.Holo.FileHeader.Keys y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Skm.Holo.FileHeader.Keys x)
        {
            return (int)x;
        }
    }



    public class LightTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.LightType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.LightType value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Skm.Holo.LightType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Skm.Holo.LightType)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableLightTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.LightType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.LightType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Skm.Holo.LightType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Skm.Holo.LightType)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class LightTypeEqualityComparer : IEqualityComparer<global::Skm.Holo.LightType>
    {
        public bool Equals(global::Skm.Holo.LightType x, global::Skm.Holo.LightType y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Skm.Holo.LightType x)
        {
            return (int)x;
        }
    }



    public class ShaderIdFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.ShaderId>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.ShaderId value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Skm.Holo.ShaderId Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Skm.Holo.ShaderId)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableShaderIdFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.ShaderId?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.ShaderId? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Skm.Holo.ShaderId? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Skm.Holo.ShaderId)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class ShaderIdEqualityComparer : IEqualityComparer<global::Skm.Holo.ShaderId>
    {
        public bool Equals(global::Skm.Holo.ShaderId x, global::Skm.Holo.ShaderId y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Skm.Holo.ShaderId x)
        {
            return (int)x;
        }
    }



    public class SKMXContainer_SubDirFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.SKMXContainer.SubDir>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.SKMXContainer.SubDir value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Skm.Holo.SKMXContainer.SubDir Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Skm.Holo.SKMXContainer.SubDir)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableSKMXContainer_SubDirFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.SKMXContainer.SubDir?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.SKMXContainer.SubDir? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Skm.Holo.SKMXContainer.SubDir? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Skm.Holo.SKMXContainer.SubDir)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class SKMXContainer_SubDirEqualityComparer : IEqualityComparer<global::Skm.Holo.SKMXContainer.SubDir>
    {
        public bool Equals(global::Skm.Holo.SKMXContainer.SubDir x, global::Skm.Holo.SKMXContainer.SubDir y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Skm.Holo.SKMXContainer.SubDir x)
        {
            return (int)x;
        }
    }



    public class SKMXContainer_StatusMsgFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.SKMXContainer.StatusMsg>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.SKMXContainer.StatusMsg value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Skm.Holo.SKMXContainer.StatusMsg Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Skm.Holo.SKMXContainer.StatusMsg)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableSKMXContainer_StatusMsgFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.SKMXContainer.StatusMsg?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.SKMXContainer.StatusMsg? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Skm.Holo.SKMXContainer.StatusMsg? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Skm.Holo.SKMXContainer.StatusMsg)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class SKMXContainer_StatusMsgEqualityComparer : IEqualityComparer<global::Skm.Holo.SKMXContainer.StatusMsg>
    {
        public bool Equals(global::Skm.Holo.SKMXContainer.StatusMsg x, global::Skm.Holo.SKMXContainer.StatusMsg y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Skm.Holo.SKMXContainer.StatusMsg x)
        {
            return (int)x;
        }
    }



    public class Texture_DataFormatFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.Texture.DataFormat>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.Texture.DataFormat value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Skm.Holo.Texture.DataFormat Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Skm.Holo.Texture.DataFormat)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableTexture_DataFormatFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Skm.Holo.Texture.DataFormat?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Skm.Holo.Texture.DataFormat? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Skm.Holo.Texture.DataFormat? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Skm.Holo.Texture.DataFormat)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class Texture_DataFormatEqualityComparer : IEqualityComparer<global::Skm.Holo.Texture.DataFormat>
    {
        public bool Equals(global::Skm.Holo.Texture.DataFormat x, global::Skm.Holo.Texture.DataFormat y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Skm.Holo.Texture.DataFormat x)
        {
            return (int)x;
        }
    }



}
#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
