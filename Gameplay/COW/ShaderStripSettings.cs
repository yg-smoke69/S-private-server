using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200028F")]
public class ShaderStripSettings : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000290")]
	public class KeywordStripInfo
	{
		[Token(Token = "0x40030F2")]
		[FieldOffset(Offset = "0x8")]
		public int DataID;

		[Token(Token = "0x40030F3")]
		[FieldOffset(Offset = "0xC")]
		public List<string> ValidKeywords;

		[Token(Token = "0x40030F4")]
		[FieldOffset(Offset = "0x10")]
		public List<string> StripKeywords;

		[Token(Token = "0x6000C93")]
		[Address(RVA = "0x20E4BF8", Offset = "0x20E4BF8", VA = "0x20E4BF8")]
		public KeywordStripInfo()
		{
		}
	}

	[Token(Token = "0x40030ED")]
	private const string EngineFileName = "ShaderStripSettings";

	[Token(Token = "0x40030EE")]
	private const int MAX_DATA_ID = 254;

	[Token(Token = "0x40030EF")]
	[FieldOffset(Offset = "0xC")]
	public KeywordStripInfo[] KeywordStripInfos;

	[Token(Token = "0x40030F0")]
	[FieldOffset(Offset = "0x0")]
	private static ShaderStripSettings m_Instance;

	[Token(Token = "0x40030F1")]
	[FieldOffset(Offset = "0x10")]
	private int m_CurActiveDataID;

	[Token(Token = "0x17000175")]
	public static ShaderStripSettings instance
	{
		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0x20E3B50", Offset = "0x20E3B50", VA = "0x20E3B50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000C8B")]
	[Address(RVA = "0x20E3B40", Offset = "0x20E3B40", VA = "0x20E3B40")]
	public ShaderStripSettings()
	{
	}

	[Token(Token = "0x6000C8D")]
	[Address(RVA = "0x20E3E0C", Offset = "0x20E3E0C", VA = "0x20E3E0C")]
	public static bool HaveEnoughStorage(long bytes)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C8E")]
	[Address(RVA = "0x20E3F08", Offset = "0x20E3F08", VA = "0x20E3F08")]
	public void SaveToEngineFile()
	{
	}

	[Token(Token = "0x6000C8F")]
	[Address(RVA = "0x20E46CC", Offset = "0x20E46CC", VA = "0x20E46CC")]
	private static void WriteKeywordsToDatas(List<string> keywords, ref List<byte> datas)
	{
	}

	[Token(Token = "0x6000C90")]
	[Address(RVA = "0x20E49E0", Offset = "0x20E49E0", VA = "0x20E49E0")]
	public void AppyStripSettings()
	{
	}

	[Token(Token = "0x6000C91")]
	[Address(RVA = "0x20E4B04", Offset = "0x20E4B04", VA = "0x20E4B04")]
	public void ApplyStripByDataID(int data_id)
	{
	}
}
