using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using WwiseGameSyncs;

namespace GCommon;

[Serializable]
[Token(Token = "0x2003F34")]
public abstract class CSVBaseData
{
	[Token(Token = "0x401AA42")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, string> s_CommonStrings;

	[Token(Token = "0x17001C23")]
	public virtual bool UsingIndexedParseData
	{
		[Token(Token = "0x6019BAF")]
		[Address(RVA = "0x307E124", Offset = "0x307E124", VA = "0x307E124", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6019BAB")]
	[Address(RVA = "0x307E11C", Offset = "0x307E11C", VA = "0x307E11C")]
	protected CSVBaseData()
	{
	}

	[Token(Token = "0x6019BAC")]
	public abstract void ParseData(long index, int fieldCount, string[] headers, string[] values);

	[Token(Token = "0x6019BAD")]
	public abstract string GetPrimaryKey();

	[Token(Token = "0x6019BAE")]
	public T As<T>() where T : CSVBaseData
	{
		return null;
	}

	[Token(Token = "0x6019BB0")]
	[Address(RVA = "0x307E12C", Offset = "0x307E12C", VA = "0x307E12C", Slot = "7")]
	public virtual string[] GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x6019BB1")]
	[Address(RVA = "0x307E134", Offset = "0x307E134", VA = "0x307E134", Slot = "8")]
	public virtual void ParseData(IIndexString ss, int[] index)
	{
	}

	[Token(Token = "0x6019BB2")]
	[Address(RVA = "0x307E138", Offset = "0x307E138", VA = "0x307E138")]
	protected static Color32 ReadHexColor(string hex)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color32);
	}

	[Token(Token = "0x6019BB3")]
	[Address(RVA = "0x307E3AC", Offset = "0x307E3AC", VA = "0x307E3AC")]
	protected static Color ReadColor(string fieldName, string[] headers, string[] values)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6019BB4")]
	[Address(RVA = "0x307E5F4", Offset = "0x307E5F4", VA = "0x307E5F4")]
	protected static Color ReadColor(string value)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6019BB5")]
	[Address(RVA = "0x307EA2C", Offset = "0x307EA2C", VA = "0x307EA2C")]
	protected static float ReadFloat(string fieldName, string[] headers, string[] values, float defaultValue = 0f)
	{
		return default(float);
	}

	[Token(Token = "0x6019BB6")]
	[Address(RVA = "0x307EAD8", Offset = "0x307EAD8", VA = "0x307EAD8")]
	protected static int ReadInt(string fieldName, string[] headers, string[] values, int defaultValue = 0)
	{
		return default(int);
	}

	[Token(Token = "0x6019BB7")]
	[Address(RVA = "0x307EB84", Offset = "0x307EB84", VA = "0x307EB84")]
	protected static int ReadInt(string value, int defaultValue = 0)
	{
		return default(int);
	}

	[Token(Token = "0x6019BB8")]
	[Address(RVA = "0x307EB8C", Offset = "0x307EB8C", VA = "0x307EB8C")]
	protected static uint ReadUInt(string fieldName, string[] headers, string[] values, uint defaultValue = 0u)
	{
		return default(uint);
	}

	[Token(Token = "0x6019BB9")]
	[Address(RVA = "0x307EC38", Offset = "0x307EC38", VA = "0x307EC38")]
	protected static uint ReadUInt(string value, uint defaultValue)
	{
		return default(uint);
	}

	[Token(Token = "0x6019BBA")]
	[Address(RVA = "0x307EC40", Offset = "0x307EC40", VA = "0x307EC40")]
	protected static uint ReadUInt(string value)
	{
		return default(uint);
	}

	[Token(Token = "0x6019BBB")]
	[Address(RVA = "0x307ECAC", Offset = "0x307ECAC", VA = "0x307ECAC")]
	protected static byte ReadByte(string value)
	{
		return default(byte);
	}

	[Token(Token = "0x6019BBC")]
	[Address(RVA = "0x307EDC0", Offset = "0x307EDC0", VA = "0x307EDC0")]
	public static void ClearCommonStrings()
	{
	}

	[Token(Token = "0x6019BBD")]
	[Address(RVA = "0x307EE7C", Offset = "0x307EE7C", VA = "0x307EE7C")]
	protected static string ReadCommonString(string value)
	{
		return null;
	}

	[Token(Token = "0x6019BBE")]
	[Address(RVA = "0x307EFD4", Offset = "0x307EFD4", VA = "0x307EFD4")]
	protected static string ReadCommonString(string fieldName, string[] headers, string[] values, [Optional] string defaultValue)
	{
		return null;
	}

	[Token(Token = "0x6019BBF")]
	[Address(RVA = "0x307F078", Offset = "0x307F078", VA = "0x307F078")]
	protected static string ReadString(string fieldName, string[] headers, string[] values, [Optional] string defaultValue)
	{
		return null;
	}

	[Token(Token = "0x6019BC0")]
	[Address(RVA = "0x307F118", Offset = "0x307F118", VA = "0x307F118")]
	protected static string[] ReadStringArray(string fieldName, string[] headers, string[] values, [Optional] string defaultValue, char InSplitChar = ',')
	{
		return null;
	}

	[Token(Token = "0x6019BC1")]
	[Address(RVA = "0x307F230", Offset = "0x307F230", VA = "0x307F230")]
	protected static uint[] ReadUIntArray(string fieldName, string[] headers, string[] values, uint defaultValue = 0u, char InSplitChar = ',')
	{
		return null;
	}

	[Token(Token = "0x6019BC2")]
	[Address(RVA = "0x307F3F8", Offset = "0x307F3F8", VA = "0x307F3F8")]
	protected static int[] ReadIntArray(string fieldName, string[] headers, string[] values, int defaultValue = 0, char InSplitChar = ',')
	{
		return null;
	}

	[Token(Token = "0x6019BC3")]
	[Address(RVA = "0x307F65C", Offset = "0x307F65C", VA = "0x307F65C")]
	protected static float[] ReadFloatArray(string fieldName, string[] headers, string[] values, char InSplitChar = '#')
	{
		return null;
	}

	[Token(Token = "0x6019BC4")]
	[Address(RVA = "0x307F82C", Offset = "0x307F82C", VA = "0x307F82C")]
	protected static bool ReadBoolean(string fieldName, string[] headers, string[] values, bool defaultValue = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6019BC5")]
	[Address(RVA = "0x307F8D8", Offset = "0x307F8D8", VA = "0x307F8D8")]
	protected static bool ReadBoolean(string value)
	{
		return default(bool);
	}

	[Token(Token = "0x6019BC6")]
	[Address(RVA = "0x307F984", Offset = "0x307F984", VA = "0x307F984")]
	protected static ResourceID ReadResourceID(string fieldName, string[] headers, string[] values, Type resVarType)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6019BC7")]
	[Address(RVA = "0x307FB24", Offset = "0x307FB24", VA = "0x307FB24")]
	protected static ResourceID ReadResourceID(string strResID, Type resVarType)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6019BC8")]
	[Address(RVA = "0x307FC78", Offset = "0x307FC78", VA = "0x307FC78")]
	protected static ResourceID[] ReadResourceIDArray(string fieldName, string[] headers, string[] values, Type resVarType, char InSplitChar = ',')
	{
		return null;
	}

	[Token(Token = "0x6019BC9")]
	[Address(RVA = "0x307FF34", Offset = "0x307FF34", VA = "0x307FF34")]
	protected static SwitchBase ReadWwiseSwitch(string fieldName, string[] headers, string[] values, Type switch_type)
	{
		return null;
	}

	[Token(Token = "0x6019BCA")]
	[Address(RVA = "0x30800F8", Offset = "0x30800F8", VA = "0x30800F8")]
	protected static StateBase ReadWwiseState(string fieldName, string[] headers, string[] values, Type state_type)
	{
		return null;
	}

	[Token(Token = "0x6019BCB")]
	[Address(RVA = "0x30802BC", Offset = "0x30802BC", VA = "0x30802BC")]
	protected static WwiseGameSyncID ReadWwiseRTPC(string fieldName, string[] headers, string[] values)
	{
		return default(WwiseGameSyncID);
	}

	[Token(Token = "0x6019BCC")]
	[Address(RVA = "0x307E458", Offset = "0x307E458", VA = "0x307E458")]
	protected static string GetFieldValueWithFieldName(string fieldName, string[] headers, string[] values, [Optional] string defaultValue)
	{
		return null;
	}

	[Token(Token = "0x6019BCD")]
	[Address(RVA = "0x3080534", Offset = "0x3080534", VA = "0x3080534")]
	public static implicit operator bool(CSVBaseData exists)
	{
		return default(bool);
	}
}
