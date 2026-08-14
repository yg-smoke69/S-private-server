using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C61")]
public class VeteranTaskUpdateNtf
{
	[Token(Token = "0x400B477")]
	[FieldOffset(Offset = "0x8")]
	private List<VeteranTaskUpdateInfo> _003Ctasks_003Ek__BackingField;

	[Token(Token = "0x400B478")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cfinished_task_cnt_003Ek__BackingField;

	[Token(Token = "0x17000A11")]
	public List<VeteranTaskUpdateInfo> tasks
	{
		[Token(Token = "0x6008301")]
		[Address(RVA = "0x435FDD0", Offset = "0x435FDD0", VA = "0x435FDD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008302")]
		[Address(RVA = "0x435FDC8", Offset = "0x435FDC8", VA = "0x435FDC8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000A12")]
	public uint finished_task_cnt
	{
		[Token(Token = "0x6008303")]
		[Address(RVA = "0x435FDD8", Offset = "0x435FDD8", VA = "0x435FDD8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008304")]
		[Address(RVA = "0x435FDE0", Offset = "0x435FDE0", VA = "0x435FDE0")]
		set
		{
		}
	}

	[Token(Token = "0x6008300")]
	[Address(RVA = "0x435FD3C", Offset = "0x435FD3C", VA = "0x435FD3C")]
	public VeteranTaskUpdateNtf()
	{
	}
}
