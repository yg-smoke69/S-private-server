using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000277")]
public class WorkshopCreateNewManager : SingletonModule<WorkshopCreateNewManager>
{
	[Token(Token = "0x4000EFA")]
	[FieldOffset(Offset = "0xC")]
	private List<WorkshopCreateNewConfigData> m_ModeList;

	[Token(Token = "0x4000EFB")]
	[FieldOffset(Offset = "0x10")]
	private List<WorkshopCreateNewConfigData> m_MapList;

	[Token(Token = "0x4000EFC")]
	[FieldOffset(Offset = "0x14")]
	private List<string> m_NewModeList;

	[Token(Token = "0x4000EFD")]
	[FieldOffset(Offset = "0x18")]
	private List<string> m_NewMapList;

	[Token(Token = "0x4000EFE")]
	[FieldOffset(Offset = "0x1C")]
	private uint m_DefaultMode;

	[Token(Token = "0x4000EFF")]
	[FieldOffset(Offset = "0x20")]
	private uint m_DefaultMap;

	[Token(Token = "0x4000F00")]
	[FieldOffset(Offset = "0x24")]
	private bool m_CustomTemplateActivated;

	[Token(Token = "0x6000C0F")]
	[Address(RVA = "0x21BEE34", Offset = "0x21BEE34", VA = "0x21BEE34")]
	public WorkshopCreateNewManager()
	{
	}

	[Token(Token = "0x6000C10")]
	[Address(RVA = "0x21BEF5C", Offset = "0x21BEF5C", VA = "0x21BEF5C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000C11")]
	[Address(RVA = "0x21BF8A0", Offset = "0x21BF8A0", VA = "0x21BF8A0")]
	public List<WorkshopCreateNewConfigData> GetModeList()
	{
		return null;
	}

	[Token(Token = "0x6000C12")]
	[Address(RVA = "0x21BF8F8", Offset = "0x21BF8F8", VA = "0x21BF8F8")]
	public List<WorkshopCreateNewConfigData> GetMapList()
	{
		return null;
	}

	[Token(Token = "0x6000C13")]
	[Address(RVA = "0x21BF950", Offset = "0x21BF950", VA = "0x21BF950")]
	public List<string> GetNewModeList()
	{
		return null;
	}

	[Token(Token = "0x6000C14")]
	[Address(RVA = "0x21BF9A8", Offset = "0x21BF9A8", VA = "0x21BF9A8")]
	public List<string> GetNewMapList()
	{
		return null;
	}

	[Token(Token = "0x6000C15")]
	[Address(RVA = "0x21BFA00", Offset = "0x21BFA00", VA = "0x21BFA00")]
	public uint GetDefaultMode()
	{
		return default(uint);
	}

	[Token(Token = "0x6000C16")]
	[Address(RVA = "0x21BFA58", Offset = "0x21BFA58", VA = "0x21BFA58")]
	public uint GetDefaultMap()
	{
		return default(uint);
	}

	[Token(Token = "0x6000C17")]
	[Address(RVA = "0x21BFAB0", Offset = "0x21BFAB0", VA = "0x21BFAB0", Slot = "7")]
	protected override void OnCleanup()
	{
	}
}
