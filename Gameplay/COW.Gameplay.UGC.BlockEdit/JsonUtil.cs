using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using LitJson;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000BB1")]
public static class JsonUtil
{
	[Token(Token = "0x4006238")]
	[FieldOffset(Offset = "0x0")]
	public static string LogTitle;

	[Token(Token = "0x4006239")]
	[FieldOffset(Offset = "0x4")]
	public static string ReadError;

	[Token(Token = "0x400623A")]
	[FieldOffset(Offset = "0x8")]
	public static string WriteError;

	[Token(Token = "0x6005878")]
	[Address(RVA = "0x2F4B194", Offset = "0x2F4B194", VA = "0x2F4B194")]
	public static void LogErrorMissingField(JsonData jsonData, string fieldName)
	{
	}

	[Token(Token = "0x6005879")]
	[Address(RVA = "0x2F4B49C", Offset = "0x2F4B49C", VA = "0x2F4B49C")]
	public static void LogErrorWrongType(JsonData jsonData, string fieldName, JsonType type)
	{
	}

	[Token(Token = "0x600587A")]
	[Address(RVA = "0x2F4B87C", Offset = "0x2F4B87C", VA = "0x2F4B87C")]
	public static void LogErrorDataIsNull()
	{
	}

	[Token(Token = "0x600587B")]
	[Address(RVA = "0x2F4B9D4", Offset = "0x2F4B9D4", VA = "0x2F4B9D4")]
	public static void LogErrorValueIsNull()
	{
	}

	[Token(Token = "0x600587C")]
	[Address(RVA = "0x2F4BB2C", Offset = "0x2F4BB2C", VA = "0x2F4BB2C")]
	public static void LogErrorCastEnumFailed(JsonData jsonData, string enumName, int value)
	{
	}

	[Token(Token = "0x600587D")]
	[Address(RVA = "0x2F4BE54", Offset = "0x2F4BE54", VA = "0x2F4BE54")]
	public static JsonData CheckData(JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	[Token(Token = "0x600587E")]
	[Address(RVA = "0x2F41028", Offset = "0x2F41028", VA = "0x2F41028")]
	public static bool BuildBool(ref bool value, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return default(bool);
	}

	[Token(Token = "0x600587F")]
	[Address(RVA = "0x2F494C0", Offset = "0x2F494C0", VA = "0x2F494C0")]
	public static bool BuildInt(ref int value, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6005880")]
	[Address(RVA = "0x2F4C044", Offset = "0x2F4C044", VA = "0x2F4C044")]
	public static bool BuildFloat(ref float value, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6005881")]
	[Address(RVA = "0x2F40EBC", Offset = "0x2F40EBC", VA = "0x2F40EBC")]
	public static string BuildString(JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	[Token(Token = "0x6005882")]
	[Address(RVA = "0x2F448A0", Offset = "0x2F448A0", VA = "0x2F448A0")]
	public static JsonData BuildObject(JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	[Token(Token = "0x6005883")]
	[Address(RVA = "0x2F411D0", Offset = "0x2F411D0", VA = "0x2F411D0")]
	public static JsonData BuildArray(JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	[Token(Token = "0x6005884")]
	[Address(RVA = "0x2F4C1B8", Offset = "0x2F4C1B8", VA = "0x2F4C1B8")]
	public static bool BuildVector3(ref Vector3 value, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6005885")]
	[Address(RVA = "0x2F4C640", Offset = "0x2F4C640", VA = "0x2F4C640")]
	public static bool BuildValueType(ref IOGCEGJJHLK value, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6005886")]
	[Address(RVA = "0x2F4C758", Offset = "0x2F4C758", VA = "0x2F4C758")]
	public static bool BuildTypeInfo(ref TypeInfo value, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6005887")]
	[Address(RVA = "0x2F4CD48", Offset = "0x2F4CD48", VA = "0x2F4CD48")]
	public static bool BuildFuncType(ref MACLCEBEDMO value, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6005888")]
	[Address(RVA = "0x2F4CE60", Offset = "0x2F4CE60", VA = "0x2F4CE60")]
	public static bool BuildEventType(ref LCIPBALGMFC value, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6005889")]
	[Address(RVA = "0x2F4CF78", Offset = "0x2F4CF78", VA = "0x2F4CF78")]
	public static bool CheckWriterAndKey(JsonWriter jsonWriter, string key)
	{
		return default(bool);
	}

	[Token(Token = "0x600588A")]
	[Address(RVA = "0x2F4D1F0", Offset = "0x2F4D1F0", VA = "0x2F4D1F0")]
	public static bool WriteBool(JsonWriter jsonWriter, string key, bool value)
	{
		return default(bool);
	}

	[Token(Token = "0x600588B")]
	[Address(RVA = "0x2F4D338", Offset = "0x2F4D338", VA = "0x2F4D338")]
	public static bool WriteInt(JsonWriter jsonWriter, string key, int value)
	{
		return default(bool);
	}

	[Token(Token = "0x600588C")]
	[Address(RVA = "0x2F4D480", Offset = "0x2F4D480", VA = "0x2F4D480")]
	public static bool WriteFloat(JsonWriter jsonWriter, string key, float value)
	{
		return default(bool);
	}

	[Token(Token = "0x600588D")]
	[Address(RVA = "0x2F4D5DC", Offset = "0x2F4D5DC", VA = "0x2F4D5DC")]
	public static bool WriteString(JsonWriter jsonWriter, string key, string value, bool ignoreIfNull = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600588E")]
	[Address(RVA = "0x2F4D780", Offset = "0x2F4D780", VA = "0x2F4D780")]
	public static bool WriteVector3(JsonWriter jsonWriter, string key, Vector3 value)
	{
		return default(bool);
	}

	[Token(Token = "0x600588F")]
	[Address(RVA = "0x2F4D998", Offset = "0x2F4D998", VA = "0x2F4D998")]
	public static bool WriteTypeInfo(JsonWriter jsonWriter, string key, TypeInfo typeInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6005890")]
	public static bool WriteList<T>(BlockEditContext context, JsonWriter jsonWriter, string key, List<T> value, Func<BlockEditContext, JsonWriter, T, bool> itemWriteFunc)
	{
		return default(bool);
	}

	[Token(Token = "0x6005891")]
	public static bool WriteDictionary<T1, T2>(BlockEditContext context, JsonWriter jsonWriter, string key, Dictionary<T1, T2> value, Func<BlockEditContext, JsonWriter, T1, T2, bool> itemWriteFunc)
	{
		return default(bool);
	}
}
