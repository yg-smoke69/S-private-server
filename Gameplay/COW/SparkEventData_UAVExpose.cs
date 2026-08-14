using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E1D")]
internal class SparkEventData_UAVExpose : SparkEventData_Base
{
	[Token(Token = "0x400BE67")]
	[FieldOffset(Offset = "0x10")]
	public ulong[] account_ids;

	[Token(Token = "0x6008FDC")]
	[Address(RVA = "0x20F5FF4", Offset = "0x20F5FF4", VA = "0x20F5FF4")]
	public SparkEventData_UAVExpose()
	{
	}

	[Token(Token = "0x6008FDD")]
	[Address(RVA = "0x20F5FFC", Offset = "0x20F5FFC", VA = "0x20F5FFC", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
