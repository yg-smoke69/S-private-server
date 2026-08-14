using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace LitJson;

[Token(Token = "0x2003B8A")]
internal class Lexer
{
	[Token(Token = "0x2003B8B")]
	private delegate bool StateHandler(FsmContext ctx);

	[Token(Token = "0x40195D2")]
	[FieldOffset(Offset = "0x0")]
	private static int[] fsm_return_table;

	[Token(Token = "0x40195D3")]
	[FieldOffset(Offset = "0x4")]
	private static StateHandler[] fsm_handler_table;

	[Token(Token = "0x40195D4")]
	[FieldOffset(Offset = "0x8")]
	private bool allow_comments;

	[Token(Token = "0x40195D5")]
	[FieldOffset(Offset = "0x9")]
	private bool allow_single_quoted_strings;

	[Token(Token = "0x40195D6")]
	[FieldOffset(Offset = "0xA")]
	private bool end_of_input;

	[Token(Token = "0x40195D7")]
	[FieldOffset(Offset = "0xC")]
	private FsmContext fsm_context;

	[Token(Token = "0x40195D8")]
	[FieldOffset(Offset = "0x10")]
	private int input_buffer;

	[Token(Token = "0x40195D9")]
	[FieldOffset(Offset = "0x14")]
	private int input_char;

	[Token(Token = "0x40195DA")]
	[FieldOffset(Offset = "0x18")]
	private TextReader reader;

	[Token(Token = "0x40195DB")]
	[FieldOffset(Offset = "0x1C")]
	private int state;

	[Token(Token = "0x40195DC")]
	[FieldOffset(Offset = "0x20")]
	private StringBuilder string_buffer;

	[Token(Token = "0x40195DD")]
	[FieldOffset(Offset = "0x24")]
	private string string_value;

	[Token(Token = "0x40195DE")]
	[FieldOffset(Offset = "0x28")]
	private int token;

	[Token(Token = "0x40195DF")]
	[FieldOffset(Offset = "0x2C")]
	private int unichar;

	[Token(Token = "0x40195E0")]
	[FieldOffset(Offset = "0x8")]
	private static StateHandler _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x40195E1")]
	[FieldOffset(Offset = "0xC")]
	private static StateHandler _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x40195E2")]
	[FieldOffset(Offset = "0x10")]
	private static StateHandler _003C_003Ef__mg_0024cache2;

	[Token(Token = "0x40195E3")]
	[FieldOffset(Offset = "0x14")]
	private static StateHandler _003C_003Ef__mg_0024cache3;

	[Token(Token = "0x40195E4")]
	[FieldOffset(Offset = "0x18")]
	private static StateHandler _003C_003Ef__mg_0024cache4;

	[Token(Token = "0x40195E5")]
	[FieldOffset(Offset = "0x1C")]
	private static StateHandler _003C_003Ef__mg_0024cache5;

	[Token(Token = "0x40195E6")]
	[FieldOffset(Offset = "0x20")]
	private static StateHandler _003C_003Ef__mg_0024cache6;

	[Token(Token = "0x40195E7")]
	[FieldOffset(Offset = "0x24")]
	private static StateHandler _003C_003Ef__mg_0024cache7;

	[Token(Token = "0x40195E8")]
	[FieldOffset(Offset = "0x28")]
	private static StateHandler _003C_003Ef__mg_0024cache8;

	[Token(Token = "0x40195E9")]
	[FieldOffset(Offset = "0x2C")]
	private static StateHandler _003C_003Ef__mg_0024cache9;

	[Token(Token = "0x40195EA")]
	[FieldOffset(Offset = "0x30")]
	private static StateHandler _003C_003Ef__mg_0024cacheA;

	[Token(Token = "0x40195EB")]
	[FieldOffset(Offset = "0x34")]
	private static StateHandler _003C_003Ef__mg_0024cacheB;

	[Token(Token = "0x40195EC")]
	[FieldOffset(Offset = "0x38")]
	private static StateHandler _003C_003Ef__mg_0024cacheC;

	[Token(Token = "0x40195ED")]
	[FieldOffset(Offset = "0x3C")]
	private static StateHandler _003C_003Ef__mg_0024cacheD;

	[Token(Token = "0x40195EE")]
	[FieldOffset(Offset = "0x40")]
	private static StateHandler _003C_003Ef__mg_0024cacheE;

	[Token(Token = "0x40195EF")]
	[FieldOffset(Offset = "0x44")]
	private static StateHandler _003C_003Ef__mg_0024cacheF;

	[Token(Token = "0x40195F0")]
	[FieldOffset(Offset = "0x48")]
	private static StateHandler _003C_003Ef__mg_0024cache10;

	[Token(Token = "0x40195F1")]
	[FieldOffset(Offset = "0x4C")]
	private static StateHandler _003C_003Ef__mg_0024cache11;

	[Token(Token = "0x40195F2")]
	[FieldOffset(Offset = "0x50")]
	private static StateHandler _003C_003Ef__mg_0024cache12;

	[Token(Token = "0x40195F3")]
	[FieldOffset(Offset = "0x54")]
	private static StateHandler _003C_003Ef__mg_0024cache13;

	[Token(Token = "0x40195F4")]
	[FieldOffset(Offset = "0x58")]
	private static StateHandler _003C_003Ef__mg_0024cache14;

	[Token(Token = "0x40195F5")]
	[FieldOffset(Offset = "0x5C")]
	private static StateHandler _003C_003Ef__mg_0024cache15;

	[Token(Token = "0x40195F6")]
	[FieldOffset(Offset = "0x60")]
	private static StateHandler _003C_003Ef__mg_0024cache16;

	[Token(Token = "0x40195F7")]
	[FieldOffset(Offset = "0x64")]
	private static StateHandler _003C_003Ef__mg_0024cache17;

	[Token(Token = "0x40195F8")]
	[FieldOffset(Offset = "0x68")]
	private static StateHandler _003C_003Ef__mg_0024cache18;

	[Token(Token = "0x40195F9")]
	[FieldOffset(Offset = "0x6C")]
	private static StateHandler _003C_003Ef__mg_0024cache19;

	[Token(Token = "0x40195FA")]
	[FieldOffset(Offset = "0x70")]
	private static StateHandler _003C_003Ef__mg_0024cache1A;

	[Token(Token = "0x40195FB")]
	[FieldOffset(Offset = "0x74")]
	private static StateHandler _003C_003Ef__mg_0024cache1B;

	[Token(Token = "0x17001873")]
	public bool AllowComments
	{
		[Token(Token = "0x6017C00")]
		[Address(RVA = "0x1C5F938", Offset = "0x1C5F938", VA = "0x1C5F938")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017C01")]
		[Address(RVA = "0x1C5F940", Offset = "0x1C5F940", VA = "0x1C5F940")]
		set
		{
		}
	}

	[Token(Token = "0x17001874")]
	public bool AllowSingleQuotedStrings
	{
		[Token(Token = "0x6017C02")]
		[Address(RVA = "0x1C5F948", Offset = "0x1C5F948", VA = "0x1C5F948")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017C03")]
		[Address(RVA = "0x1C5F950", Offset = "0x1C5F950", VA = "0x1C5F950")]
		set
		{
		}
	}

	[Token(Token = "0x17001875")]
	public bool EndOfInput
	{
		[Token(Token = "0x6017C04")]
		[Address(RVA = "0x1C5F958", Offset = "0x1C5F958", VA = "0x1C5F958")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001876")]
	public int Token
	{
		[Token(Token = "0x6017C05")]
		[Address(RVA = "0x1C5F960", Offset = "0x1C5F960", VA = "0x1C5F960")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001877")]
	public string StringValue
	{
		[Token(Token = "0x6017C06")]
		[Address(RVA = "0x1C5F968", Offset = "0x1C5F968", VA = "0x1C5F968")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6017BFE")]
	[Address(RVA = "0x1C5D768", Offset = "0x1C5D768", VA = "0x1C5D768")]
	static Lexer()
	{
	}

	[Token(Token = "0x6017BFF")]
	[Address(RVA = "0x1C5F85C", Offset = "0x1C5F85C", VA = "0x1C5F85C")]
	public Lexer(TextReader reader)
	{
	}

	[Token(Token = "0x6017C07")]
	[Address(RVA = "0x1C5F970", Offset = "0x1C5F970", VA = "0x1C5F970")]
	private static int HexValue(int digit)
	{
		return default(int);
	}

	[Token(Token = "0x6017C08")]
	[Address(RVA = "0x1C5D76C", Offset = "0x1C5D76C", VA = "0x1C5D76C")]
	private static void PopulateFsmTables()
	{
	}

	[Token(Token = "0x6017C09")]
	[Address(RVA = "0x1C5FA28", Offset = "0x1C5FA28", VA = "0x1C5FA28")]
	private static char ProcessEscChar(int esc_char)
	{
		return default(char);
	}

	[Token(Token = "0x6017C0A")]
	[Address(RVA = "0x1C5FB30", Offset = "0x1C5FB30", VA = "0x1C5FB30")]
	private static bool State1(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C0B")]
	[Address(RVA = "0x1C5FED8", Offset = "0x1C5FED8", VA = "0x1C5FED8")]
	private static bool State2(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C0C")]
	[Address(RVA = "0x1C60040", Offset = "0x1C60040", VA = "0x1C60040")]
	private static bool State3(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C0D")]
	[Address(RVA = "0x1C602CC", Offset = "0x1C602CC", VA = "0x1C602CC")]
	private static bool State4(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C0E")]
	[Address(RVA = "0x1C604B0", Offset = "0x1C604B0", VA = "0x1C604B0")]
	private static bool State5(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C0F")]
	[Address(RVA = "0x1C605A8", Offset = "0x1C605A8", VA = "0x1C605A8")]
	private static bool State6(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C10")]
	[Address(RVA = "0x1C607CC", Offset = "0x1C607CC", VA = "0x1C607CC")]
	private static bool State7(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C11")]
	[Address(RVA = "0x1C608E8", Offset = "0x1C608E8", VA = "0x1C608E8")]
	private static bool State8(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C12")]
	[Address(RVA = "0x1C60A90", Offset = "0x1C60A90", VA = "0x1C60A90")]
	private static bool State9(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C13")]
	[Address(RVA = "0x1C60B08", Offset = "0x1C60B08", VA = "0x1C60B08")]
	private static bool State10(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C14")]
	[Address(RVA = "0x1C60B80", Offset = "0x1C60B80", VA = "0x1C60B80")]
	private static bool State11(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C15")]
	[Address(RVA = "0x1C60BF8", Offset = "0x1C60BF8", VA = "0x1C60BF8")]
	private static bool State12(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C16")]
	[Address(RVA = "0x1C60C70", Offset = "0x1C60C70", VA = "0x1C60C70")]
	private static bool State13(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C17")]
	[Address(RVA = "0x1C60CE8", Offset = "0x1C60CE8", VA = "0x1C60CE8")]
	private static bool State14(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C18")]
	[Address(RVA = "0x1C60D60", Offset = "0x1C60D60", VA = "0x1C60D60")]
	private static bool State15(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C19")]
	[Address(RVA = "0x1C60DD8", Offset = "0x1C60DD8", VA = "0x1C60DD8")]
	private static bool State16(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C1A")]
	[Address(RVA = "0x1C60E50", Offset = "0x1C60E50", VA = "0x1C60E50")]
	private static bool State17(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C1B")]
	[Address(RVA = "0x1C60EC8", Offset = "0x1C60EC8", VA = "0x1C60EC8")]
	private static bool State18(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C1C")]
	[Address(RVA = "0x1C60F40", Offset = "0x1C60F40", VA = "0x1C60F40")]
	private static bool State19(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C1D")]
	[Address(RVA = "0x1C6105C", Offset = "0x1C6105C", VA = "0x1C6105C")]
	private static bool State20(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C1E")]
	[Address(RVA = "0x1C610D4", Offset = "0x1C610D4", VA = "0x1C610D4")]
	private static bool State21(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C1F")]
	[Address(RVA = "0x1C61294", Offset = "0x1C61294", VA = "0x1C61294")]
	private static bool State22(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C20")]
	[Address(RVA = "0x1C615C4", Offset = "0x1C615C4", VA = "0x1C615C4")]
	private static bool State23(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C21")]
	[Address(RVA = "0x1C616E0", Offset = "0x1C616E0", VA = "0x1C616E0")]
	private static bool State24(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C22")]
	[Address(RVA = "0x1C61778", Offset = "0x1C61778", VA = "0x1C61778")]
	private static bool State25(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C23")]
	[Address(RVA = "0x1C61804", Offset = "0x1C61804", VA = "0x1C61804")]
	private static bool State26(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C24")]
	[Address(RVA = "0x1C61884", Offset = "0x1C61884", VA = "0x1C61884")]
	private static bool State27(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C25")]
	[Address(RVA = "0x1C61904", Offset = "0x1C61904", VA = "0x1C61904")]
	private static bool State28(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C26")]
	[Address(RVA = "0x1C5FEA8", Offset = "0x1C5FEA8", VA = "0x1C5FEA8")]
	private bool GetChar()
	{
		return default(bool);
	}

	[Token(Token = "0x6017C27")]
	[Address(RVA = "0x1C619A4", Offset = "0x1C619A4", VA = "0x1C619A4")]
	private int NextChar()
	{
		return default(int);
	}

	[Token(Token = "0x6017C28")]
	[Address(RVA = "0x1C619F0", Offset = "0x1C619F0", VA = "0x1C619F0")]
	public bool NextToken()
	{
		return default(bool);
	}

	[Token(Token = "0x6017C29")]
	[Address(RVA = "0x1C602C0", Offset = "0x1C602C0", VA = "0x1C602C0")]
	private void UngetChar()
	{
	}
}
