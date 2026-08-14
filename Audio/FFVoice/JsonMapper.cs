using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Il2CppDummyDll;

namespace FFVoice;

[Token(Token = "0x2003B51")]
public class JsonMapper
{
	[Token(Token = "0x2003B52")]
	private sealed class _003CRegisterExporter_003Ec__AnonStorey0<T>
	{
		[Token(Token = "0x401942F")]
		[FieldOffset(Offset = "0x0")]
		internal ExporterFunc<T> exporter;

		[Token(Token = "0x6017996")]
		public _003CRegisterExporter_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6017997")]
		internal void _003C_003Em__0(object obj, JsonWriter writer)
		{
		}
	}

	[Token(Token = "0x2003B53")]
	private sealed class _003CRegisterImporter_003Ec__AnonStorey1<TJson, TValue>
	{
		[Token(Token = "0x4019430")]
		[FieldOffset(Offset = "0x0")]
		internal ImporterFunc<TJson, TValue> importer;

		[Token(Token = "0x6017998")]
		public _003CRegisterImporter_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6017999")]
		internal object _003C_003Em__0(object input)
		{
			return null;
		}
	}

	[Token(Token = "0x4019406")]
	[FieldOffset(Offset = "0x0")]
	private static int max_nesting_depth;

	[Token(Token = "0x4019407")]
	[FieldOffset(Offset = "0x4")]
	private static IFormatProvider datetime_format;

	[Token(Token = "0x4019408")]
	[FieldOffset(Offset = "0x8")]
	private static IDictionary<Type, ExporterFunc> base_exporters_table;

	[Token(Token = "0x4019409")]
	[FieldOffset(Offset = "0xC")]
	private static IDictionary<Type, ExporterFunc> custom_exporters_table;

	[Token(Token = "0x401940A")]
	[FieldOffset(Offset = "0x10")]
	private static IDictionary<Type, IDictionary<Type, ImporterFunc>> base_importers_table;

	[Token(Token = "0x401940B")]
	[FieldOffset(Offset = "0x14")]
	private static IDictionary<Type, IDictionary<Type, ImporterFunc>> custom_importers_table;

	[Token(Token = "0x401940C")]
	[FieldOffset(Offset = "0x18")]
	private static IDictionary<Type, ArrayMetadata> array_metadata;

	[Token(Token = "0x401940D")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly object array_metadata_lock;

	[Token(Token = "0x401940E")]
	[FieldOffset(Offset = "0x20")]
	private static IDictionary<Type, IDictionary<Type, MethodInfo>> conv_ops;

	[Token(Token = "0x401940F")]
	[FieldOffset(Offset = "0x24")]
	private static readonly object conv_ops_lock;

	[Token(Token = "0x4019410")]
	[FieldOffset(Offset = "0x28")]
	private static IDictionary<Type, ObjectMetadata> object_metadata;

	[Token(Token = "0x4019411")]
	[FieldOffset(Offset = "0x2C")]
	private static readonly object object_metadata_lock;

	[Token(Token = "0x4019412")]
	[FieldOffset(Offset = "0x30")]
	private static IDictionary<Type, IList<PropertyMetadata>> type_properties;

	[Token(Token = "0x4019413")]
	[FieldOffset(Offset = "0x34")]
	private static readonly object type_properties_lock;

	[Token(Token = "0x4019414")]
	[FieldOffset(Offset = "0x38")]
	private static JsonWriter static_writer;

	[Token(Token = "0x4019415")]
	[FieldOffset(Offset = "0x3C")]
	private static readonly object static_writer_lock;

	[Token(Token = "0x4019416")]
	[FieldOffset(Offset = "0x40")]
	private static WrapperFactory _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4019417")]
	[FieldOffset(Offset = "0x44")]
	private static ExporterFunc _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4019418")]
	[FieldOffset(Offset = "0x48")]
	private static ExporterFunc _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4019419")]
	[FieldOffset(Offset = "0x4C")]
	private static ExporterFunc _003C_003Ef__am_0024cache3;

	[Token(Token = "0x401941A")]
	[FieldOffset(Offset = "0x50")]
	private static ExporterFunc _003C_003Ef__am_0024cache4;

	[Token(Token = "0x401941B")]
	[FieldOffset(Offset = "0x54")]
	private static ExporterFunc _003C_003Ef__am_0024cache5;

	[Token(Token = "0x401941C")]
	[FieldOffset(Offset = "0x58")]
	private static ExporterFunc _003C_003Ef__am_0024cache6;

	[Token(Token = "0x401941D")]
	[FieldOffset(Offset = "0x5C")]
	private static ExporterFunc _003C_003Ef__am_0024cache7;

	[Token(Token = "0x401941E")]
	[FieldOffset(Offset = "0x60")]
	private static ExporterFunc _003C_003Ef__am_0024cache8;

	[Token(Token = "0x401941F")]
	[FieldOffset(Offset = "0x64")]
	private static ExporterFunc _003C_003Ef__am_0024cache9;

	[Token(Token = "0x4019420")]
	[FieldOffset(Offset = "0x68")]
	private static ImporterFunc _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x4019421")]
	[FieldOffset(Offset = "0x6C")]
	private static ImporterFunc _003C_003Ef__am_0024cacheB;

	[Token(Token = "0x4019422")]
	[FieldOffset(Offset = "0x70")]
	private static ImporterFunc _003C_003Ef__am_0024cacheC;

	[Token(Token = "0x4019423")]
	[FieldOffset(Offset = "0x74")]
	private static ImporterFunc _003C_003Ef__am_0024cacheD;

	[Token(Token = "0x4019424")]
	[FieldOffset(Offset = "0x78")]
	private static ImporterFunc _003C_003Ef__am_0024cacheE;

	[Token(Token = "0x4019425")]
	[FieldOffset(Offset = "0x7C")]
	private static ImporterFunc _003C_003Ef__am_0024cacheF;

	[Token(Token = "0x4019426")]
	[FieldOffset(Offset = "0x80")]
	private static ImporterFunc _003C_003Ef__am_0024cache10;

	[Token(Token = "0x4019427")]
	[FieldOffset(Offset = "0x84")]
	private static ImporterFunc _003C_003Ef__am_0024cache11;

	[Token(Token = "0x4019428")]
	[FieldOffset(Offset = "0x88")]
	private static ImporterFunc _003C_003Ef__am_0024cache12;

	[Token(Token = "0x4019429")]
	[FieldOffset(Offset = "0x8C")]
	private static ImporterFunc _003C_003Ef__am_0024cache13;

	[Token(Token = "0x401942A")]
	[FieldOffset(Offset = "0x90")]
	private static ImporterFunc _003C_003Ef__am_0024cache14;

	[Token(Token = "0x401942B")]
	[FieldOffset(Offset = "0x94")]
	private static ImporterFunc _003C_003Ef__am_0024cache15;

	[Token(Token = "0x401942C")]
	[FieldOffset(Offset = "0x98")]
	private static WrapperFactory _003C_003Ef__am_0024cache16;

	[Token(Token = "0x401942D")]
	[FieldOffset(Offset = "0x9C")]
	private static WrapperFactory _003C_003Ef__am_0024cache17;

	[Token(Token = "0x401942E")]
	[FieldOffset(Offset = "0xA0")]
	private static WrapperFactory _003C_003Ef__am_0024cache18;

	[Token(Token = "0x6017962")]
	[Address(RVA = "0x321F09C", Offset = "0x321F09C", VA = "0x321F09C")]
	static JsonMapper()
	{
	}

	[Token(Token = "0x6017963")]
	[Address(RVA = "0x3221488", Offset = "0x3221488", VA = "0x3221488")]
	public JsonMapper()
	{
	}

	[Token(Token = "0x6017964")]
	[Address(RVA = "0x3221490", Offset = "0x3221490", VA = "0x3221490")]
	private static void AddArrayMetadata(Type type)
	{
	}

	[Token(Token = "0x6017965")]
	[Address(RVA = "0x3221A4C", Offset = "0x3221A4C", VA = "0x3221A4C")]
	private static void AddObjectMetadata(Type type)
	{
	}

	[Token(Token = "0x6017966")]
	[Address(RVA = "0x3222298", Offset = "0x3222298", VA = "0x3222298")]
	private static void AddTypeProperties(Type type)
	{
	}

	[Token(Token = "0x6017967")]
	[Address(RVA = "0x32228C0", Offset = "0x32228C0", VA = "0x32228C0")]
	private static MethodInfo GetConvOp(Type t1, Type t2)
	{
		return null;
	}

	[Token(Token = "0x6017968")]
	[Address(RVA = "0x322334C", Offset = "0x322334C", VA = "0x322334C")]
	private static object ReadValue(Type inst_type, JsonReader reader)
	{
		return null;
	}

	[Token(Token = "0x6017969")]
	[Address(RVA = "0x32250A0", Offset = "0x32250A0", VA = "0x32250A0")]
	private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader)
	{
		return null;
	}

	[Token(Token = "0x601796A")]
	[Address(RVA = "0x3224F50", Offset = "0x3224F50", VA = "0x3224F50")]
	private static void ReadSkip(JsonReader reader)
	{
	}

	[Token(Token = "0x601796B")]
	[Address(RVA = "0x321F3D0", Offset = "0x321F3D0", VA = "0x321F3D0")]
	private static void RegisterBaseExporters()
	{
	}

	[Token(Token = "0x601796C")]
	[Address(RVA = "0x322044C", Offset = "0x322044C", VA = "0x322044C")]
	private static void RegisterBaseImporters()
	{
	}

	[Token(Token = "0x601796D")]
	[Address(RVA = "0x3225B6C", Offset = "0x3225B6C", VA = "0x3225B6C")]
	private static void RegisterImporter(IDictionary<Type, IDictionary<Type, ImporterFunc>> table, Type json_type, Type value_type, ImporterFunc importer)
	{
	}

	[Token(Token = "0x601796E")]
	[Address(RVA = "0x3225E50", Offset = "0x3225E50", VA = "0x3225E50")]
	private static void WriteValue(object obj, JsonWriter writer, bool writer_is_private, int depth)
	{
	}

	[Token(Token = "0x601796F")]
	[Address(RVA = "0x3227F78", Offset = "0x3227F78", VA = "0x3227F78")]
	public static string ToJson(object obj)
	{
		return null;
	}

	[Token(Token = "0x6017970")]
	[Address(RVA = "0x322814C", Offset = "0x322814C", VA = "0x322814C")]
	public static void ToJson(object obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x6017971")]
	[Address(RVA = "0x32281E4", Offset = "0x32281E4", VA = "0x32281E4")]
	public static JsonData ToObject(JsonReader reader)
	{
		return null;
	}

	[Token(Token = "0x6017972")]
	[Address(RVA = "0x32283DC", Offset = "0x32283DC", VA = "0x32283DC")]
	public static JsonData ToObject(TextReader reader)
	{
		return null;
	}

	[Token(Token = "0x6017973")]
	[Address(RVA = "0x32140F4", Offset = "0x32140F4", VA = "0x32140F4")]
	public static JsonData ToObject(string json)
	{
		return null;
	}

	[Token(Token = "0x6017974")]
	public static T ToObject<T>(JsonReader reader)
	{
		return (T)null;
	}

	[Token(Token = "0x6017975")]
	public static T ToObject<T>(TextReader reader)
	{
		return (T)null;
	}

	[Token(Token = "0x6017976")]
	public static T ToObject<T>(string json)
	{
		return (T)null;
	}

	[Token(Token = "0x6017977")]
	[Address(RVA = "0x3225AE4", Offset = "0x3225AE4", VA = "0x3225AE4")]
	public static IJsonWrapper ToWrapper(WrapperFactory factory, JsonReader reader)
	{
		return null;
	}

	[Token(Token = "0x6017978")]
	[Address(RVA = "0x32285F8", Offset = "0x32285F8", VA = "0x32285F8")]
	public static IJsonWrapper ToWrapper(WrapperFactory factory, string json)
	{
		return null;
	}

	[Token(Token = "0x6017979")]
	public static void RegisterExporter<T>(ExporterFunc<T> exporter)
	{
	}

	[Token(Token = "0x601797A")]
	public static void RegisterImporter<TJson, TValue>(ImporterFunc<TJson, TValue> importer)
	{
	}

	[Token(Token = "0x601797B")]
	[Address(RVA = "0x32286A4", Offset = "0x32286A4", VA = "0x32286A4")]
	public static void UnregisterExporters()
	{
	}

	[Token(Token = "0x601797C")]
	[Address(RVA = "0x32287B8", Offset = "0x32287B8", VA = "0x32287B8")]
	public static void UnregisterImporters()
	{
	}

	[Token(Token = "0x601797D")]
	[Address(RVA = "0x32288CC", Offset = "0x32288CC", VA = "0x32288CC")]
	private static IJsonWrapper _003CReadSkip_003Em__0()
	{
		return null;
	}

	[Token(Token = "0x601797E")]
	[Address(RVA = "0x3228938", Offset = "0x3228938", VA = "0x3228938")]
	private static void _003CRegisterBaseExporters_003Em__1(object obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x601797F")]
	[Address(RVA = "0x32289FC", Offset = "0x32289FC", VA = "0x32289FC")]
	private static void _003CRegisterBaseExporters_003Em__2(object obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x6017980")]
	[Address(RVA = "0x3228AC0", Offset = "0x3228AC0", VA = "0x3228AC0")]
	private static void _003CRegisterBaseExporters_003Em__3(object obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x6017981")]
	[Address(RVA = "0x3228BE0", Offset = "0x3228BE0", VA = "0x3228BE0")]
	private static void _003CRegisterBaseExporters_003Em__4(object obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x6017982")]
	[Address(RVA = "0x3228C78", Offset = "0x3228C78", VA = "0x3228C78")]
	private static void _003CRegisterBaseExporters_003Em__5(object obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x6017983")]
	[Address(RVA = "0x3228D3C", Offset = "0x3228D3C", VA = "0x3228D3C")]
	private static void _003CRegisterBaseExporters_003Em__6(object obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x6017984")]
	[Address(RVA = "0x3228E00", Offset = "0x3228E00", VA = "0x3228E00")]
	private static void _003CRegisterBaseExporters_003Em__7(object obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x6017985")]
	[Address(RVA = "0x3228EC4", Offset = "0x3228EC4", VA = "0x3228EC4")]
	private static void _003CRegisterBaseExporters_003Em__8(object obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x6017986")]
	[Address(RVA = "0x3228F9C", Offset = "0x3228F9C", VA = "0x3228F9C")]
	private static void _003CRegisterBaseExporters_003Em__9(object obj, JsonWriter writer)
	{
	}

	[Token(Token = "0x6017987")]
	[Address(RVA = "0x3229030", Offset = "0x3229030", VA = "0x3229030")]
	private static object _003CRegisterBaseImporters_003Em__A(object input)
	{
		return null;
	}

	[Token(Token = "0x6017988")]
	[Address(RVA = "0x32290F4", Offset = "0x32290F4", VA = "0x32290F4")]
	private static object _003CRegisterBaseImporters_003Em__B(object input)
	{
		return null;
	}

	[Token(Token = "0x6017989")]
	[Address(RVA = "0x32291B8", Offset = "0x32291B8", VA = "0x32291B8")]
	private static object _003CRegisterBaseImporters_003Em__C(object input)
	{
		return null;
	}

	[Token(Token = "0x601798A")]
	[Address(RVA = "0x322927C", Offset = "0x322927C", VA = "0x322927C")]
	private static object _003CRegisterBaseImporters_003Em__D(object input)
	{
		return null;
	}

	[Token(Token = "0x601798B")]
	[Address(RVA = "0x3229340", Offset = "0x3229340", VA = "0x3229340")]
	private static object _003CRegisterBaseImporters_003Em__E(object input)
	{
		return null;
	}

	[Token(Token = "0x601798C")]
	[Address(RVA = "0x3229404", Offset = "0x3229404", VA = "0x3229404")]
	private static object _003CRegisterBaseImporters_003Em__F(object input)
	{
		return null;
	}

	[Token(Token = "0x601798D")]
	[Address(RVA = "0x32294C8", Offset = "0x32294C8", VA = "0x32294C8")]
	private static object _003CRegisterBaseImporters_003Em__10(object input)
	{
		return null;
	}

	[Token(Token = "0x601798E")]
	[Address(RVA = "0x322958C", Offset = "0x322958C", VA = "0x322958C")]
	private static object _003CRegisterBaseImporters_003Em__11(object input)
	{
		return null;
	}

	[Token(Token = "0x601798F")]
	[Address(RVA = "0x3229650", Offset = "0x3229650", VA = "0x3229650")]
	private static object _003CRegisterBaseImporters_003Em__12(object input)
	{
		return null;
	}

	[Token(Token = "0x6017990")]
	[Address(RVA = "0x3229724", Offset = "0x3229724", VA = "0x3229724")]
	private static object _003CRegisterBaseImporters_003Em__13(object input)
	{
		return null;
	}

	[Token(Token = "0x6017991")]
	[Address(RVA = "0x32297E8", Offset = "0x32297E8", VA = "0x32297E8")]
	private static object _003CRegisterBaseImporters_003Em__14(object input)
	{
		return null;
	}

	[Token(Token = "0x6017992")]
	[Address(RVA = "0x3229910", Offset = "0x3229910", VA = "0x3229910")]
	private static object _003CRegisterBaseImporters_003Em__15(object input)
	{
		return null;
	}

	[Token(Token = "0x6017993")]
	[Address(RVA = "0x3229A88", Offset = "0x3229A88", VA = "0x3229A88")]
	private static IJsonWrapper _003CToObject_003Em__16()
	{
		return null;
	}

	[Token(Token = "0x6017994")]
	[Address(RVA = "0x3229AF4", Offset = "0x3229AF4", VA = "0x3229AF4")]
	private static IJsonWrapper _003CToObject_003Em__17()
	{
		return null;
	}

	[Token(Token = "0x6017995")]
	[Address(RVA = "0x3229B60", Offset = "0x3229B60", VA = "0x3229B60")]
	private static IJsonWrapper _003CToObject_003Em__18()
	{
		return null;
	}
}
