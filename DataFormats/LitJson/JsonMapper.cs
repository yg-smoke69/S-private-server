using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Il2CppDummyDll;

namespace LitJson;

[Token(Token = "0x2003B80")]
public class JsonMapper
{
	[Token(Token = "0x2003B81")]
	private sealed class _003CRegisterExporter_003Ec__AnonStorey0<T>
	{
		[Token(Token = "0x4019599")]
		[FieldOffset(Offset = "0x0")]
		internal ExporterFunc<T> exporter;

		[Token(Token = "0x6017B88")]
		public _003CRegisterExporter_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6017B89")]
		internal void _003C_003Em__0(object obj, JsonWriter writer)
		{
		}
	}

	[Token(Token = "0x2003B82")]
	private sealed class _003CRegisterImporter_003Ec__AnonStorey1<TJson, TValue>
	{
		[Token(Token = "0x401959A")]
		[FieldOffset(Offset = "0x0")]
		internal ImporterFunc<TJson, TValue> importer;

		[Token(Token = "0x6017B8A")]
		public _003CRegisterImporter_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6017B8B")]
		internal object _003C_003Em__0(object input)
		{
			return null;
		}
	}

	[Token(Token = "0x401956D")]
	[FieldOffset(Offset = "0x0")]
	private static int max_nesting_depth;

	[Token(Token = "0x401956E")]
	[FieldOffset(Offset = "0x4")]
	private static IFormatProvider datetime_format;

	[Token(Token = "0x401956F")]
	[FieldOffset(Offset = "0x8")]
	private static IDictionary<Type, ExporterFunc> base_exporters_table;

	[Token(Token = "0x4019570")]
	[FieldOffset(Offset = "0xC")]
	private static IDictionary<Type, ExporterFunc> custom_exporters_table;

	[Token(Token = "0x4019571")]
	[FieldOffset(Offset = "0x10")]
	private static IDictionary<Type, IDictionary<Type, ImporterFunc>> base_importers_table;

	[Token(Token = "0x4019572")]
	[FieldOffset(Offset = "0x14")]
	private static IDictionary<Type, IDictionary<Type, ImporterFunc>> custom_importers_table;

	[Token(Token = "0x4019573")]
	[FieldOffset(Offset = "0x18")]
	private static IDictionary<Type, ArrayMetadata> array_metadata;

	[Token(Token = "0x4019574")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly object array_metadata_lock;

	[Token(Token = "0x4019575")]
	[FieldOffset(Offset = "0x20")]
	private static IDictionary<Type, IDictionary<Type, MethodInfo>> conv_ops;

	[Token(Token = "0x4019576")]
	[FieldOffset(Offset = "0x24")]
	private static readonly object conv_ops_lock;

	[Token(Token = "0x4019577")]
	[FieldOffset(Offset = "0x28")]
	private static IDictionary<Type, ObjectMetadata> object_metadata;

	[Token(Token = "0x4019578")]
	[FieldOffset(Offset = "0x2C")]
	private static readonly object object_metadata_lock;

	[Token(Token = "0x4019579")]
	[FieldOffset(Offset = "0x30")]
	private static IDictionary<Type, IList<PropertyMetadata>> type_properties;

	[Token(Token = "0x401957A")]
	[FieldOffset(Offset = "0x34")]
	private static readonly object type_properties_lock;

	[Token(Token = "0x401957B")]
	[FieldOffset(Offset = "0x38")]
	private static JsonWriter static_writer;

	[Token(Token = "0x401957C")]
	[FieldOffset(Offset = "0x3C")]
	private static readonly object static_writer_lock;

	[Token(Token = "0x401957D")]
	[FieldOffset(Offset = "0x40")]
	private static WrapperFactory _003C_003Ef__am_0024cache0;

	[Token(Token = "0x401957E")]
	[FieldOffset(Offset = "0x44")]
	private static ExporterFunc _003C_003Ef__am_0024cache1;

	[Token(Token = "0x401957F")]
	[FieldOffset(Offset = "0x48")]
	private static ExporterFunc _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4019580")]
	[FieldOffset(Offset = "0x4C")]
	private static ExporterFunc _003C_003Ef__am_0024cache3;

	[Token(Token = "0x4019581")]
	[FieldOffset(Offset = "0x50")]
	private static ExporterFunc _003C_003Ef__am_0024cache4;

	[Token(Token = "0x4019582")]
	[FieldOffset(Offset = "0x54")]
	private static ExporterFunc _003C_003Ef__am_0024cache5;

	[Token(Token = "0x4019583")]
	[FieldOffset(Offset = "0x58")]
	private static ExporterFunc _003C_003Ef__am_0024cache6;

	[Token(Token = "0x4019584")]
	[FieldOffset(Offset = "0x5C")]
	private static ExporterFunc _003C_003Ef__am_0024cache7;

	[Token(Token = "0x4019585")]
	[FieldOffset(Offset = "0x60")]
	private static ExporterFunc _003C_003Ef__am_0024cache8;

	[Token(Token = "0x4019586")]
	[FieldOffset(Offset = "0x64")]
	private static ExporterFunc _003C_003Ef__am_0024cache9;

	[Token(Token = "0x4019587")]
	[FieldOffset(Offset = "0x68")]
	private static ExporterFunc _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x4019588")]
	[FieldOffset(Offset = "0x6C")]
	private static ImporterFunc _003C_003Ef__am_0024cacheB;

	[Token(Token = "0x4019589")]
	[FieldOffset(Offset = "0x70")]
	private static ImporterFunc _003C_003Ef__am_0024cacheC;

	[Token(Token = "0x401958A")]
	[FieldOffset(Offset = "0x74")]
	private static ImporterFunc _003C_003Ef__am_0024cacheD;

	[Token(Token = "0x401958B")]
	[FieldOffset(Offset = "0x78")]
	private static ImporterFunc _003C_003Ef__am_0024cacheE;

	[Token(Token = "0x401958C")]
	[FieldOffset(Offset = "0x7C")]
	private static ImporterFunc _003C_003Ef__am_0024cacheF;

	[Token(Token = "0x401958D")]
	[FieldOffset(Offset = "0x80")]
	private static ImporterFunc _003C_003Ef__am_0024cache10;

	[Token(Token = "0x401958E")]
	[FieldOffset(Offset = "0x84")]
	private static ImporterFunc _003C_003Ef__am_0024cache11;

	[Token(Token = "0x401958F")]
	[FieldOffset(Offset = "0x88")]
	private static ImporterFunc _003C_003Ef__am_0024cache12;

	[Token(Token = "0x4019590")]
	[FieldOffset(Offset = "0x8C")]
	private static ImporterFunc _003C_003Ef__am_0024cache13;

	[Token(Token = "0x4019591")]
	[FieldOffset(Offset = "0x90")]
	private static ImporterFunc _003C_003Ef__am_0024cache14;

	[Token(Token = "0x4019592")]
	[FieldOffset(Offset = "0x94")]
	private static ImporterFunc _003C_003Ef__am_0024cache15;

	[Token(Token = "0x4019593")]
	[FieldOffset(Offset = "0x98")]
	private static ImporterFunc _003C_003Ef__am_0024cache16;

	[Token(Token = "0x4019594")]
	[FieldOffset(Offset = "0x9C")]
	private static ImporterFunc _003C_003Ef__am_0024cache17;

	[Token(Token = "0x4019595")]
	[FieldOffset(Offset = "0xA0")]
	private static ImporterFunc _003C_003Ef__am_0024cache18;

	[Token(Token = "0x4019596")]
	[FieldOffset(Offset = "0xA4")]
	private static WrapperFactory _003C_003Ef__am_0024cache19;

	[Token(Token = "0x4019597")]
	[FieldOffset(Offset = "0xA8")]
	private static WrapperFactory _003C_003Ef__am_0024cache1A;

	[Token(Token = "0x4019598")]
	[FieldOffset(Offset = "0xAC")]
	private static WrapperFactory _003C_003Ef__am_0024cache1B;

	[Token(Token = "0x6017B50")]
	[Address(RVA = "0x311FF50", Offset = "0x311FF50", VA = "0x311FF50")]
	static JsonMapper()
	{
	}

	[Token(Token = "0x6017B51")]
	[Address(RVA = "0x3122850", Offset = "0x3122850", VA = "0x3122850")]
	public JsonMapper()
	{
	}

	[Token(Token = "0x6017B52")]
	[Address(RVA = "0x3122858", Offset = "0x3122858", VA = "0x3122858")]
	private static void AddArrayMetadata(Type type)
	{
	}

	[Token(Token = "0x6017B53")]
	[Address(RVA = "0x3122E14", Offset = "0x3122E14", VA = "0x3122E14")]
	private static void AddObjectMetadata(Type type)
	{
	}

	[Token(Token = "0x6017B54")]
	[Address(RVA = "0x3123660", Offset = "0x3123660", VA = "0x3123660")]
	private static void AddTypeProperties(Type type)
	{
	}

	[Token(Token = "0x6017B55")]
	[Address(RVA = "0x3123C88", Offset = "0x3123C88", VA = "0x3123C88")]
	private static MethodInfo GetConvOp(Type t1, Type t2)
	{
		return null;
	}

	[Token(Token = "0x6017B56")]
	[Address(RVA = "0x3124714", Offset = "0x3124714", VA = "0x3124714")]
	private static object ReadValue(Type inst_type, JsonReader reader)
	{
		return null;
	}

	[Token(Token = "0x6017B57")]
	[Address(RVA = "0x3126A14", Offset = "0x3126A14", VA = "0x3126A14")]
	private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader)
	{
		return null;
	}

	[Token(Token = "0x6017B58")]
	[Address(RVA = "0x31268C4", Offset = "0x31268C4", VA = "0x31268C4")]
	private static void ReadSkip(JsonReader reader)
	{
	}

	[Token(Token = "0x6017B59")]
	[Address(RVA = "0x312032C", Offset = "0x312032C", VA = "0x312032C")]
	private static void RegisterBaseExporters()
	{
	}

	[Token(Token = "0x6017B5A")]
	[Address(RVA = "0x3121570", Offset = "0x3121570", VA = "0x3121570")]
	private static void RegisterBaseImporters()
	{
	}

	[Token(Token = "0x6017B5B")]
	[Address(RVA = "0x3127348", Offset = "0x3127348", VA = "0x3127348")]
	private static void RegisterImporter(IDictionary<Type, IDictionary<Type, ImporterFunc>> table, Type json_type, Type value_type, ImporterFunc importer)
	{
	}

	[Token(Token = "0x6017B5C")]
	[Address(RVA = "0x312762C", Offset = "0x312762C", VA = "0x312762C")]
	private static void WriteValue(object obj, JsonWriter writer, bool writer_is_private, int depth)
	{
	}

	[Token(Token = "0x6017B5D")]
	[Address(RVA = "0x3129824", Offset = "0x3129824", VA = "0x3129824")]
	public static string ToJson(object obj)
	{
		return null;
	}

	[Token(Token = "0x6017B5E")]
	[Address(RVA = "0x3129AF4", Offset = "0x3129AF4", VA = "0x3129AF4")]
	public static void ToJson(object obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x6017B5F")]
	[Address(RVA = "0x3129B8C", Offset = "0x3129B8C", VA = "0x3129B8C")]
	public static JsonData ToObject(JsonReader reader)
	{
		return null;
	}

	[Token(Token = "0x6017B60")]
	[Address(RVA = "0x3129D84", Offset = "0x3129D84", VA = "0x3129D84")]
	public static JsonData ToObject(TextReader reader)
	{
		return null;
	}

	[Token(Token = "0x6017B61")]
	[Address(RVA = "0x3129FA8", Offset = "0x3129FA8", VA = "0x3129FA8")]
	public static JsonData ToObject(string json)
	{
		return null;
	}

	[Token(Token = "0x6017B62")]
	[Address(RVA = "0x3126814", Offset = "0x3126814", VA = "0x3126814")]
	public static object ToObject(string json, Type inst_type)
	{
		return null;
	}

	[Token(Token = "0x6017B63")]
	public static T ToObject<T>(JsonReader reader)
	{
		return (T)null;
	}

	[Token(Token = "0x6017B64")]
	public static T ToObject<T>(TextReader reader)
	{
		return (T)null;
	}

	[Token(Token = "0x6017B65")]
	public static T ToObject<T>(string json)
	{
		return (T)null;
	}

	[Token(Token = "0x6017B66")]
	[Address(RVA = "0x31272C0", Offset = "0x31272C0", VA = "0x31272C0")]
	public static IJsonWrapper ToWrapper(WrapperFactory factory, JsonReader reader)
	{
		return null;
	}

	[Token(Token = "0x6017B67")]
	[Address(RVA = "0x312A1A0", Offset = "0x312A1A0", VA = "0x312A1A0")]
	public static IJsonWrapper ToWrapper(WrapperFactory factory, string json)
	{
		return null;
	}

	[Token(Token = "0x6017B68")]
	public static void RegisterExporter<T>(ExporterFunc<T> exporter)
	{
	}

	[Token(Token = "0x6017B69")]
	public static void RegisterImporter<TJson, TValue>(ImporterFunc<TJson, TValue> importer)
	{
	}

	[Token(Token = "0x6017B6A")]
	[Address(RVA = "0x312A2CC", Offset = "0x312A2CC", VA = "0x312A2CC")]
	public static void UnregisterExporters()
	{
	}

	[Token(Token = "0x6017B6B")]
	[Address(RVA = "0x312A3E0", Offset = "0x312A3E0", VA = "0x312A3E0")]
	public static void UnregisterImporters()
	{
	}

	[Token(Token = "0x6017B6C")]
	[Address(RVA = "0x312A4F4", Offset = "0x312A4F4", VA = "0x312A4F4")]
	private static IJsonWrapper _003CReadSkip_003Em__0()
	{
		return null;
	}

	[Token(Token = "0x6017B6D")]
	[Address(RVA = "0x312A568", Offset = "0x312A568", VA = "0x312A568")]
	private static void _003CRegisterBaseExporters_003Em__1(object obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x6017B6E")]
	[Address(RVA = "0x312A628", Offset = "0x312A628", VA = "0x312A628")]
	private static void _003CRegisterBaseExporters_003Em__2(object obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x6017B6F")]
	[Address(RVA = "0x312A6E8", Offset = "0x312A6E8", VA = "0x312A6E8")]
	private static void _003CRegisterBaseExporters_003Em__3(object obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x6017B70")]
	[Address(RVA = "0x312A804", Offset = "0x312A804", VA = "0x312A804")]
	private static void _003CRegisterBaseExporters_003Em__4(object obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x6017B71")]
	[Address(RVA = "0x312A9C4", Offset = "0x312A9C4", VA = "0x312A9C4")]
	private static void _003CRegisterBaseExporters_003Em__5(object obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x6017B72")]
	[Address(RVA = "0x312AA84", Offset = "0x312AA84", VA = "0x312AA84")]
	private static void _003CRegisterBaseExporters_003Em__6(object obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x6017B73")]
	[Address(RVA = "0x312AB44", Offset = "0x312AB44", VA = "0x312AB44")]
	private static void _003CRegisterBaseExporters_003Em__7(object obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x6017B74")]
	[Address(RVA = "0x312AC04", Offset = "0x312AC04", VA = "0x312AC04")]
	private static void _003CRegisterBaseExporters_003Em__8(object obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x6017B75")]
	[Address(RVA = "0x312ACD4", Offset = "0x312ACD4", VA = "0x312ACD4")]
	private static void _003CRegisterBaseExporters_003Em__9(object obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x6017B76")]
	[Address(RVA = "0x312AD60", Offset = "0x312AD60", VA = "0x312AD60")]
	private static void _003CRegisterBaseExporters_003Em__A(object obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x6017B77")]
	[Address(RVA = "0x312AE30", Offset = "0x312AE30", VA = "0x312AE30")]
	private static object _003CRegisterBaseImporters_003Em__B(object input)
	{
		return null;
	}

	[Token(Token = "0x6017B78")]
	[Address(RVA = "0x312AEF4", Offset = "0x312AEF4", VA = "0x312AEF4")]
	private static object _003CRegisterBaseImporters_003Em__C(object input)
	{
		return null;
	}

	[Token(Token = "0x6017B79")]
	[Address(RVA = "0x312AFB8", Offset = "0x312AFB8", VA = "0x312AFB8")]
	private static object _003CRegisterBaseImporters_003Em__D(object input)
	{
		return null;
	}

	[Token(Token = "0x6017B7A")]
	[Address(RVA = "0x312B07C", Offset = "0x312B07C", VA = "0x312B07C")]
	private static object _003CRegisterBaseImporters_003Em__E(object input)
	{
		return null;
	}

	[Token(Token = "0x6017B7B")]
	[Address(RVA = "0x312B140", Offset = "0x312B140", VA = "0x312B140")]
	private static object _003CRegisterBaseImporters_003Em__F(object input)
	{
		return null;
	}

	[Token(Token = "0x6017B7C")]
	[Address(RVA = "0x312B204", Offset = "0x312B204", VA = "0x312B204")]
	private static object _003CRegisterBaseImporters_003Em__10(object input)
	{
		return null;
	}

	[Token(Token = "0x6017B7D")]
	[Address(RVA = "0x312B2C8", Offset = "0x312B2C8", VA = "0x312B2C8")]
	private static object _003CRegisterBaseImporters_003Em__11(object input)
	{
		return null;
	}

	[Token(Token = "0x6017B7E")]
	[Address(RVA = "0x312B38C", Offset = "0x312B38C", VA = "0x312B38C")]
	private static object _003CRegisterBaseImporters_003Em__12(object input)
	{
		return null;
	}

	[Token(Token = "0x6017B7F")]
	[Address(RVA = "0x312B450", Offset = "0x312B450", VA = "0x312B450")]
	private static object _003CRegisterBaseImporters_003Em__13(object input)
	{
		return null;
	}

	[Token(Token = "0x6017B80")]
	[Address(RVA = "0x312B524", Offset = "0x312B524", VA = "0x312B524")]
	private static object _003CRegisterBaseImporters_003Em__14(object input)
	{
		return null;
	}

	[Token(Token = "0x6017B81")]
	[Address(RVA = "0x312B5E8", Offset = "0x312B5E8", VA = "0x312B5E8")]
	private static object _003CRegisterBaseImporters_003Em__15(object input)
	{
		return null;
	}

	[Token(Token = "0x6017B82")]
	[Address(RVA = "0x312B6AC", Offset = "0x312B6AC", VA = "0x312B6AC")]
	private static object _003CRegisterBaseImporters_003Em__16(object input)
	{
		return null;
	}

	[Token(Token = "0x6017B83")]
	[Address(RVA = "0x312B770", Offset = "0x312B770", VA = "0x312B770")]
	private static object _003CRegisterBaseImporters_003Em__17(object input)
	{
		return null;
	}

	[Token(Token = "0x6017B84")]
	[Address(RVA = "0x312B898", Offset = "0x312B898", VA = "0x312B898")]
	private static object _003CRegisterBaseImporters_003Em__18(object input)
	{
		return null;
	}

	[Token(Token = "0x6017B85")]
	[Address(RVA = "0x312BA10", Offset = "0x312BA10", VA = "0x312BA10")]
	private static IJsonWrapper _003CToObject_003Em__19()
	{
		return null;
	}

	[Token(Token = "0x6017B86")]
	[Address(RVA = "0x312BA7C", Offset = "0x312BA7C", VA = "0x312BA7C")]
	private static IJsonWrapper _003CToObject_003Em__1A()
	{
		return null;
	}

	[Token(Token = "0x6017B87")]
	[Address(RVA = "0x312BAE8", Offset = "0x312BAE8", VA = "0x312BAE8")]
	private static IJsonWrapper _003CToObject_003Em__1B()
	{
		return null;
	}
}
