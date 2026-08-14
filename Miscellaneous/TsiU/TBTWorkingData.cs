using System.Collections.Generic;
using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C31")]
public class TBTWorkingData : TAny
{
	[Token(Token = "0x4019A16")]
	[FieldOffset(Offset = "0x8")]
	internal Dictionary<int, TBTActionContext> _context;

	[Token(Token = "0x17001975")]
	internal Dictionary<int, TBTActionContext> context
	{
		[Token(Token = "0x6018053")]
		[Address(RVA = "0x2641844", Offset = "0x2641844", VA = "0x2641844")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6018052")]
	[Address(RVA = "0x26417B8", Offset = "0x26417B8", VA = "0x26417B8")]
	public TBTWorkingData()
	{
	}

	[Token(Token = "0x6018054")]
	[Address(RVA = "0x264184C", Offset = "0x264184C", VA = "0x264184C", Slot = "1")]
	~TBTWorkingData()
	{
	}
}
