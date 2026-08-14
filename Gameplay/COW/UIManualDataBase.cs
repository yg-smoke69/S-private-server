using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E46")]
public class UIManualDataBase
{
	[Token(Token = "0x2002E47")]
	public enum Type
	{
		[Token(Token = "0x4011B10")]
		NONE,
		[Token(Token = "0x4011B11")]
		GROW,
		[Token(Token = "0x4011B12")]
		MAP_DEBRIS,
		[Token(Token = "0x4011B13")]
		MAP_SUPPLY,
		[Token(Token = "0x4011B14")]
		MAP_EVENT,
		[Token(Token = "0x4011B15")]
		MAP_MOV,
		[Token(Token = "0x4011B16")]
		WEAPON,
		[Token(Token = "0x4011B17")]
		MORE
	}

	[Token(Token = "0x2002E48")]
	public delegate UIManualContentBaseController ContentCreator();

	[Token(Token = "0x4011B00")]
	[FieldOffset(Offset = "0x8")]
	public Type m_ContentType;

	[Token(Token = "0x4011B01")]
	[FieldOffset(Offset = "0xC")]
	public List<ManualChallenge> m_Desc;

	[Token(Token = "0x4011B02")]
	[FieldOffset(Offset = "0x10")]
	public ContentCreator m_Creator;

	[Token(Token = "0x4011B03")]
	[FieldOffset(Offset = "0x14")]
	public string m_TitleKey;

	[Token(Token = "0x4011B04")]
	[FieldOffset(Offset = "0x18")]
	public ETipsType m_TipsType;

	[Token(Token = "0x4011B05")]
	[FieldOffset(Offset = "0x1C")]
	public ETipsType m_NewTipsType;

	[Token(Token = "0x4011B06")]
	[FieldOffset(Offset = "0x20")]
	public bool m_ToFirstPage;

	[Token(Token = "0x4011B07")]
	[FieldOffset(Offset = "0x21")]
	public bool m_ToLastPage;

	[Token(Token = "0x4011B08")]
	[FieldOffset(Offset = "0x22")]
	public bool m_IsFirstSubTabInTotalList;

	[Token(Token = "0x4011B09")]
	[FieldOffset(Offset = "0x23")]
	public bool m_IsLastSubTabInTotalList;

	[Token(Token = "0x4011B0A")]
	[FieldOffset(Offset = "0x24")]
	public Action m_OnPrevPageEnd;

	[Token(Token = "0x4011B0B")]
	[FieldOffset(Offset = "0x28")]
	public Action m_OnNextPageEnd;

	[Token(Token = "0x4011B0C")]
	[FieldOffset(Offset = "0x2C")]
	public Action<bool> m_OnPageUpdate;

	[Token(Token = "0x4011B0D")]
	[FieldOffset(Offset = "0x30")]
	public int m_Index;

	[Token(Token = "0x4011B0E")]
	[FieldOffset(Offset = "0x34")]
	public int m_Type;

	[Token(Token = "0x60135D4")]
	[Address(RVA = "0x2C22A58", Offset = "0x2C22A58", VA = "0x2C22A58")]
	public UIManualDataBase()
	{
	}

	[Token(Token = "0x60135D5")]
	[Address(RVA = "0x2C22AE4", Offset = "0x2C22AE4", VA = "0x2C22AE4", Slot = "4")]
	public virtual void Init()
	{
	}
}
