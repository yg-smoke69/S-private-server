using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace FFVoice;

[Token(Token = "0x2003B5B")]
internal class Lexer
{
	[Token(Token = "0x2003B5C")]
	private delegate bool StateHandler(FsmContext ctx);

	[Token(Token = "0x4019467")]
	[FieldOffset(Offset = "0x0")]
	private static int[] fsm_return_table;

	[Token(Token = "0x4019468")]
	[FieldOffset(Offset = "0x4")]
	private static StateHandler[] fsm_handler_table;

	[Token(Token = "0x4019469")]
	[FieldOffset(Offset = "0x8")]
	private bool allow_comments;

	[Token(Token = "0x401946A")]
	[FieldOffset(Offset = "0x9")]
	private bool allow_single_quoted_strings;

	[Token(Token = "0x401946B")]
	[FieldOffset(Offset = "0xA")]
	private bool end_of_input;

	[Token(Token = "0x401946C")]
	[FieldOffset(Offset = "0xC")]
	private FsmContext fsm_context;

	[Token(Token = "0x401946D")]
	[FieldOffset(Offset = "0x10")]
	private int input_buffer;

	[Token(Token = "0x401946E")]
	[FieldOffset(Offset = "0x14")]
	private int input_char;

	[Token(Token = "0x401946F")]
	[FieldOffset(Offset = "0x18")]
	private TextReader reader;

	[Token(Token = "0x4019470")]
	[FieldOffset(Offset = "0x1C")]
	private int state;

	[Token(Token = "0x4019471")]
	[FieldOffset(Offset = "0x20")]
	private StringBuilder string_buffer;

	[Token(Token = "0x4019472")]
	[FieldOffset(Offset = "0x24")]
	private string string_value;

	[Token(Token = "0x4019473")]
	[FieldOffset(Offset = "0x28")]
	private int token;

	[Token(Token = "0x4019474")]
	[FieldOffset(Offset = "0x2C")]
	private int unichar;

	[Token(Token = "0x4019475")]
	[FieldOffset(Offset = "0x8")]
	private static StateHandler _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x4019476")]
	[FieldOffset(Offset = "0xC")]
	private static StateHandler _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x4019477")]
	[FieldOffset(Offset = "0x10")]
	private static StateHandler _003C_003Ef__mg_0024cache2;

	[Token(Token = "0x4019478")]
	[FieldOffset(Offset = "0x14")]
	private static StateHandler _003C_003Ef__mg_0024cache3;

	[Token(Token = "0x4019479")]
	[FieldOffset(Offset = "0x18")]
	private static StateHandler _003C_003Ef__mg_0024cache4;

	[Token(Token = "0x401947A")]
	[FieldOffset(Offset = "0x1C")]
	private static StateHandler _003C_003Ef__mg_0024cache5;

	[Token(Token = "0x401947B")]
	[FieldOffset(Offset = "0x20")]
	private static StateHandler _003C_003Ef__mg_0024cache6;

	[Token(Token = "0x401947C")]
	[FieldOffset(Offset = "0x24")]
	private static StateHandler _003C_003Ef__mg_0024cache7;

	[Token(Token = "0x401947D")]
	[FieldOffset(Offset = "0x28")]
	private static StateHandler _003C_003Ef__mg_0024cache8;

	[Token(Token = "0x401947E")]
	[FieldOffset(Offset = "0x2C")]
	private static StateHandler _003C_003Ef__mg_0024cache9;

	[Token(Token = "0x401947F")]
	[FieldOffset(Offset = "0x30")]
	private static StateHandler _003C_003Ef__mg_0024cacheA;

	[Token(Token = "0x4019480")]
	[FieldOffset(Offset = "0x34")]
	private static StateHandler _003C_003Ef__mg_0024cacheB;

	[Token(Token = "0x4019481")]
	[FieldOffset(Offset = "0x38")]
	private static StateHandler _003C_003Ef__mg_0024cacheC;

	[Token(Token = "0x4019482")]
	[FieldOffset(Offset = "0x3C")]
	private static StateHandler _003C_003Ef__mg_0024cacheD;

	[Token(Token = "0x4019483")]
	[FieldOffset(Offset = "0x40")]
	private static StateHandler _003C_003Ef__mg_0024cacheE;

	[Token(Token = "0x4019484")]
	[FieldOffset(Offset = "0x44")]
	private static StateHandler _003C_003Ef__mg_0024cacheF;

	[Token(Token = "0x4019485")]
	[FieldOffset(Offset = "0x48")]
	private static StateHandler _003C_003Ef__mg_0024cache10;

	[Token(Token = "0x4019486")]
	[FieldOffset(Offset = "0x4C")]
	private static StateHandler _003C_003Ef__mg_0024cache11;

	[Token(Token = "0x4019487")]
	[FieldOffset(Offset = "0x50")]
	private static StateHandler _003C_003Ef__mg_0024cache12;

	[Token(Token = "0x4019488")]
	[FieldOffset(Offset = "0x54")]
	private static StateHandler _003C_003Ef__mg_0024cache13;

	[Token(Token = "0x4019489")]
	[FieldOffset(Offset = "0x58")]
	private static StateHandler _003C_003Ef__mg_0024cache14;

	[Token(Token = "0x401948A")]
	[FieldOffset(Offset = "0x5C")]
	private static StateHandler _003C_003Ef__mg_0024cache15;

	[Token(Token = "0x401948B")]
	[FieldOffset(Offset = "0x60")]
	private static StateHandler _003C_003Ef__mg_0024cache16;

	[Token(Token = "0x401948C")]
	[FieldOffset(Offset = "0x64")]
	private static StateHandler _003C_003Ef__mg_0024cache17;

	[Token(Token = "0x401948D")]
	[FieldOffset(Offset = "0x68")]
	private static StateHandler _003C_003Ef__mg_0024cache18;

	[Token(Token = "0x401948E")]
	[FieldOffset(Offset = "0x6C")]
	private static StateHandler _003C_003Ef__mg_0024cache19;

	[Token(Token = "0x401948F")]
	[FieldOffset(Offset = "0x70")]
	private static StateHandler _003C_003Ef__mg_0024cache1A;

	[Token(Token = "0x4019490")]
	[FieldOffset(Offset = "0x74")]
	private static StateHandler _003C_003Ef__mg_0024cache1B;

	[Token(Token = "0x17001820")]
	public bool AllowComments
	{
		[Token(Token = "0x6017A0C")]
		[Address(RVA = "0x26A3958", Offset = "0x26A3958", VA = "0x26A3958")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017A0D")]
		[Address(RVA = "0x26A3988", Offset = "0x26A3988", VA = "0x26A3988")]
		set
		{
		}
	}

	[Token(Token = "0x17001821")]
	public bool AllowSingleQuotedStrings
	{
		[Token(Token = "0x6017A0E")]
		[Address(RVA = "0x26A39B4", Offset = "0x26A39B4", VA = "0x26A39B4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017A0F")]
		[Address(RVA = "0x26A39E4", Offset = "0x26A39E4", VA = "0x26A39E4")]
		set
		{
		}
	}

	[Token(Token = "0x17001822")]
	public bool EndOfInput
	{
		[Token(Token = "0x6017A10")]
		[Address(RVA = "0x26A44CC", Offset = "0x26A44CC", VA = "0x26A44CC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001823")]
	public int Token
	{
		[Token(Token = "0x6017A11")]
		[Address(RVA = "0x26A4534", Offset = "0x26A4534", VA = "0x26A4534")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001824")]
	public string StringValue
	{
		[Token(Token = "0x6017A12")]
		[Address(RVA = "0x26A414C", Offset = "0x26A414C", VA = "0x26A414C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6017A0A")]
	[Address(RVA = "0x26A6904", Offset = "0x26A6904", VA = "0x26A6904")]
	static Lexer()
	{
	}

	[Token(Token = "0x6017A0B")]
	[Address(RVA = "0x26A3858", Offset = "0x26A3858", VA = "0x26A3858")]
	public Lexer(TextReader reader)
	{
	}

	[Token(Token = "0x6017A13")]
	[Address(RVA = "0x26A89F8", Offset = "0x26A89F8", VA = "0x26A89F8")]
	private static int HexValue(int digit)
	{
		return default(int);
	}

	[Token(Token = "0x6017A14")]
	[Address(RVA = "0x26A6908", Offset = "0x26A6908", VA = "0x26A6908")]
	private static void PopulateFsmTables()
	{
	}

	[Token(Token = "0x6017A15")]
	[Address(RVA = "0x26A8AB0", Offset = "0x26A8AB0", VA = "0x26A8AB0")]
	private static char ProcessEscChar(int esc_char)
	{
		return default(char);
	}

	[Token(Token = "0x6017A16")]
	[Address(RVA = "0x26A8BB8", Offset = "0x26A8BB8", VA = "0x26A8BB8")]
	private static bool State1(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A17")]
	[Address(RVA = "0x26A8F60", Offset = "0x26A8F60", VA = "0x26A8F60")]
	private static bool State2(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A18")]
	[Address(RVA = "0x26A90C8", Offset = "0x26A90C8", VA = "0x26A90C8")]
	private static bool State3(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A19")]
	[Address(RVA = "0x26A9354", Offset = "0x26A9354", VA = "0x26A9354")]
	private static bool State4(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A1A")]
	[Address(RVA = "0x26A9538", Offset = "0x26A9538", VA = "0x26A9538")]
	private static bool State5(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A1B")]
	[Address(RVA = "0x26A9630", Offset = "0x26A9630", VA = "0x26A9630")]
	private static bool State6(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A1C")]
	[Address(RVA = "0x26A9854", Offset = "0x26A9854", VA = "0x26A9854")]
	private static bool State7(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A1D")]
	[Address(RVA = "0x26A9970", Offset = "0x26A9970", VA = "0x26A9970")]
	private static bool State8(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A1E")]
	[Address(RVA = "0x26A9B18", Offset = "0x26A9B18", VA = "0x26A9B18")]
	private static bool State9(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A1F")]
	[Address(RVA = "0x26A9B90", Offset = "0x26A9B90", VA = "0x26A9B90")]
	private static bool State10(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A20")]
	[Address(RVA = "0x26A9C08", Offset = "0x26A9C08", VA = "0x26A9C08")]
	private static bool State11(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A21")]
	[Address(RVA = "0x26A9C80", Offset = "0x26A9C80", VA = "0x26A9C80")]
	private static bool State12(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A22")]
	[Address(RVA = "0x26A9CF8", Offset = "0x26A9CF8", VA = "0x26A9CF8")]
	private static bool State13(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A23")]
	[Address(RVA = "0x26A9D70", Offset = "0x26A9D70", VA = "0x26A9D70")]
	private static bool State14(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A24")]
	[Address(RVA = "0x26A9DE8", Offset = "0x26A9DE8", VA = "0x26A9DE8")]
	private static bool State15(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A25")]
	[Address(RVA = "0x26A9E60", Offset = "0x26A9E60", VA = "0x26A9E60")]
	private static bool State16(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A26")]
	[Address(RVA = "0x26A9ED8", Offset = "0x26A9ED8", VA = "0x26A9ED8")]
	private static bool State17(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A27")]
	[Address(RVA = "0x26A9F50", Offset = "0x26A9F50", VA = "0x26A9F50")]
	private static bool State18(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A28")]
	[Address(RVA = "0x26A9FC8", Offset = "0x26A9FC8", VA = "0x26A9FC8")]
	private static bool State19(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A29")]
	[Address(RVA = "0x26AA0E4", Offset = "0x26AA0E4", VA = "0x26AA0E4")]
	private static bool State20(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A2A")]
	[Address(RVA = "0x26AA15C", Offset = "0x26AA15C", VA = "0x26AA15C")]
	private static bool State21(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A2B")]
	[Address(RVA = "0x26AA31C", Offset = "0x26AA31C", VA = "0x26AA31C")]
	private static bool State22(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A2C")]
	[Address(RVA = "0x26AA64C", Offset = "0x26AA64C", VA = "0x26AA64C")]
	private static bool State23(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A2D")]
	[Address(RVA = "0x26AA768", Offset = "0x26AA768", VA = "0x26AA768")]
	private static bool State24(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A2E")]
	[Address(RVA = "0x26AA800", Offset = "0x26AA800", VA = "0x26AA800")]
	private static bool State25(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A2F")]
	[Address(RVA = "0x26AA88C", Offset = "0x26AA88C", VA = "0x26AA88C")]
	private static bool State26(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A30")]
	[Address(RVA = "0x26AA90C", Offset = "0x26AA90C", VA = "0x26AA90C")]
	private static bool State27(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A31")]
	[Address(RVA = "0x26AA98C", Offset = "0x26AA98C", VA = "0x26AA98C")]
	private static bool State28(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017A32")]
	[Address(RVA = "0x26A8F30", Offset = "0x26A8F30", VA = "0x26A8F30")]
	private bool GetChar()
	{
		return default(bool);
	}

	[Token(Token = "0x6017A33")]
	[Address(RVA = "0x26AAA2C", Offset = "0x26AAA2C", VA = "0x26AAA2C")]
	private int NextChar()
	{
		return default(int);
	}

	[Token(Token = "0x6017A34")]
	[Address(RVA = "0x26A41E0", Offset = "0x26A41E0", VA = "0x26A41E0")]
	public bool NextToken()
	{
		return default(bool);
	}

	[Token(Token = "0x6017A35")]
	[Address(RVA = "0x26A9348", Offset = "0x26A9348", VA = "0x26A9348")]
	private void UngetChar()
	{
	}
}
