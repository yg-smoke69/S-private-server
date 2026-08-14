using System.Collections.Generic;
using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C36")]
public class TLogger : TStaticHelperBase<TLogger>
{
	[Token(Token = "0x2003C37")]
	public enum LOGGER_CHANNEL
	{
		[Token(Token = "0x4019A1E")]
		DEFAULT,
		[Token(Token = "0x4019A1F")]
		WARNING,
		[Token(Token = "0x4019A20")]
		INFO,
		[Token(Token = "0x4019A21")]
		TODO,
		[Token(Token = "0x4019A22")]
		ERROR,
		[Token(Token = "0x4019A23")]
		DEBUG,
		[Token(Token = "0x4019A24")]
		PROFILE,
		[Token(Token = "0x4019A25")]
		NUM
	}

	[Token(Token = "0x2003C38")]
	public enum LOGGER_REDIRECTION
	{
		[Token(Token = "0x4019A27")]
		CONSOLE,
		[Token(Token = "0x4019A28")]
		STRING,
		[Token(Token = "0x4019A29")]
		FILE
	}

	[Token(Token = "0x4019A1B")]
	[FieldOffset(Offset = "0xC")]
	private bool[] _enabledChannel;

	[Token(Token = "0x4019A1C")]
	[FieldOffset(Offset = "0x10")]
	private List<TILoggerListener> _listeners;

	[Token(Token = "0x6018064")]
	[Address(RVA = "0x2642CBC", Offset = "0x2642CBC", VA = "0x2642CBC")]
	public TLogger()
	{
	}

	[Token(Token = "0x6018065")]
	[Address(RVA = "0x2642D20", Offset = "0x2642D20", VA = "0x2642D20")]
	public static void DEBUG(string msg)
	{
	}

	[Token(Token = "0x6018066")]
	[Address(RVA = "0x26416FC", Offset = "0x26416FC", VA = "0x26416FC")]
	public static void WARNING(string msg)
	{
	}

	[Token(Token = "0x6018067")]
	[Address(RVA = "0x26433C4", Offset = "0x26433C4", VA = "0x26433C4")]
	public static void INFO(string msg)
	{
	}

	[Token(Token = "0x6018068")]
	[Address(RVA = "0x2643480", Offset = "0x2643480", VA = "0x2643480")]
	public static void TODO(string msg)
	{
	}

	[Token(Token = "0x6018069")]
	[Address(RVA = "0x264353C", Offset = "0x264353C", VA = "0x264353C")]
	public static void ERROR(string msg)
	{
	}

	[Token(Token = "0x601806A")]
	[Address(RVA = "0x26435F8", Offset = "0x26435F8", VA = "0x26435F8")]
	public static void PROFILE(string msg)
	{
	}

	[Token(Token = "0x601806B")]
	[Address(RVA = "0x26436B4", Offset = "0x26436B4", VA = "0x26436B4", Slot = "4")]
	protected override void onInit()
	{
	}

	[Token(Token = "0x601806C")]
	[Address(RVA = "0x26437BC", Offset = "0x26437BC", VA = "0x26437BC")]
	public void EnableChannel(LOGGER_CHANNEL channel, bool isEnabled)
	{
	}

	[Token(Token = "0x601806D")]
	[Address(RVA = "0x264386C", Offset = "0x264386C", VA = "0x264386C")]
	public void AddLogListener(TILoggerListener listener)
	{
	}

	[Token(Token = "0x601806E")]
	[Address(RVA = "0x2642DDC", Offset = "0x2642DDC", VA = "0x2642DDC")]
	public void Log(string msg, LOGGER_CHANNEL channel, bool simpleMode)
	{
	}
}
