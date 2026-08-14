using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002D9C")]
public class AutoPopupWindowDataManager : SingletonModule<AutoPopupWindowDataManager>
{
	[Token(Token = "0x4011817")]
	[FieldOffset(Offset = "0xC")]
	private int strategy;

	[Token(Token = "0x4011818")]
	[FieldOffset(Offset = "0x10")]
	private List<AutoPopupWindowCtrlData> m_Data;

	[Token(Token = "0x17001389")]
	private string AutoPopupWindowStrategy
	{
		[Token(Token = "0x601317C")]
		[Address(RVA = "0x10E8890", Offset = "0x10E8890", VA = "0x10E8890")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601317B")]
	[Address(RVA = "0x10E8800", Offset = "0x10E8800", VA = "0x10E8800")]
	public AutoPopupWindowDataManager()
	{
	}

	[Token(Token = "0x601317D")]
	[Address(RVA = "0x10E8A28", Offset = "0x10E8A28", VA = "0x10E8A28", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x601317E")]
	[Address(RVA = "0x10E8AE8", Offset = "0x10E8AE8", VA = "0x10E8AE8", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x601317F")]
	[Address(RVA = "0x10E8D48", Offset = "0x10E8D48", VA = "0x10E8D48")]
	public int LevelLimit(AutoPopupWindowID windowID)
	{
		return default(int);
	}

	[Token(Token = "0x6013180")]
	[Address(RVA = "0x10E8F24", Offset = "0x10E8F24", VA = "0x10E8F24")]
	public int RegDayLimit(AutoPopupWindowID windowID)
	{
		return default(int);
	}
}
