using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E52")]
public class AutoTaskCommonErrorWnd : AutoPopupTask
{
	[Token(Token = "0x400BF2F")]
	[FieldOffset(Offset = "0x8")]
	private UICommonErrorWndController m_UIController;

	[Token(Token = "0x400BF30")]
	[FieldOffset(Offset = "0xC")]
	private string _003CMessage_003Ek__BackingField;

	[Token(Token = "0x400BF31")]
	[FieldOffset(Offset = "0x10")]
	private string _003CTitle_003Ek__BackingField;

	[Token(Token = "0x400BF32")]
	[FieldOffset(Offset = "0x14")]
	private Action _003CCallback_003Ek__BackingField;

	[Token(Token = "0x17000F33")]
	public string Message
	{
		[Token(Token = "0x60091AC")]
		[Address(RVA = "0x10EFDA0", Offset = "0x10EFDA0", VA = "0x10EFDA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60091AD")]
		[Address(RVA = "0x10EFDA8", Offset = "0x10EFDA8", VA = "0x10EFDA8")]
		set
		{
		}
	}

	[Token(Token = "0x17000F34")]
	public string Title
	{
		[Token(Token = "0x60091AE")]
		[Address(RVA = "0x10EFDB0", Offset = "0x10EFDB0", VA = "0x10EFDB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60091AF")]
		[Address(RVA = "0x10EFDB8", Offset = "0x10EFDB8", VA = "0x10EFDB8")]
		set
		{
		}
	}

	[Token(Token = "0x17000F35")]
	public Action Callback
	{
		[Token(Token = "0x60091B0")]
		[Address(RVA = "0x10EFDC0", Offset = "0x10EFDC0", VA = "0x10EFDC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60091B1")]
		[Address(RVA = "0x10EFDC8", Offset = "0x10EFDC8", VA = "0x10EFDC8")]
		set
		{
		}
	}

	[Token(Token = "0x60091AB")]
	[Address(RVA = "0x10EFD98", Offset = "0x10EFD98", VA = "0x10EFD98")]
	public AutoTaskCommonErrorWnd()
	{
	}

	[Token(Token = "0x60091B2")]
	[Address(RVA = "0x10EFDD0", Offset = "0x10EFDD0", VA = "0x10EFDD0", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x60091B3")]
	[Address(RVA = "0x10EFF2C", Offset = "0x10EFF2C", VA = "0x10EFF2C", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x60091B4")]
	[Address(RVA = "0x10F002C", Offset = "0x10F002C", VA = "0x10F002C", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}
}
