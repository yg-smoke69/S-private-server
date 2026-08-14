using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C3D")]
internal class TDiscreteEvent
{
	[Token(Token = "0x2003C3E")]
	internal delegate int DiscreteEventAction(TAny workingData);

	[Token(Token = "0x4019A32")]
	[FieldOffset(Offset = "0x8")]
	private TTimeAbs _003CTriggeredTime_003Ek__BackingField;

	[Token(Token = "0x4019A33")]
	[FieldOffset(Offset = "0x10")]
	private int _003CPriority_003Ek__BackingField;

	[Token(Token = "0x4019A34")]
	[FieldOffset(Offset = "0x14")]
	private DiscreteEventAction _003CEventAction_003Ek__BackingField;

	[Token(Token = "0x17001978")]
	internal TTimeAbs TriggeredTime
	{
		[Token(Token = "0x60180C9")]
		[Address(RVA = "0x2641BC8", Offset = "0x2641BC8", VA = "0x2641BC8")]
		get
		{
			return default(TTimeAbs);
		}
		[Token(Token = "0x60180CA")]
		[Address(RVA = "0x2641BD4", Offset = "0x2641BD4", VA = "0x2641BD4")]
		set
		{
		}
	}

	[Token(Token = "0x17001979")]
	internal int Priority
	{
		[Token(Token = "0x60180CB")]
		[Address(RVA = "0x2641BE4", Offset = "0x2641BE4", VA = "0x2641BE4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60180CC")]
		[Address(RVA = "0x2641BEC", Offset = "0x2641BEC", VA = "0x2641BEC")]
		set
		{
		}
	}

	[Token(Token = "0x1700197A")]
	internal DiscreteEventAction EventAction
	{
		[Token(Token = "0x60180CD")]
		[Address(RVA = "0x2641BF4", Offset = "0x2641BF4", VA = "0x2641BF4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60180CE")]
		[Address(RVA = "0x2641BFC", Offset = "0x2641BFC", VA = "0x2641BFC")]
		set
		{
		}
	}

	[Token(Token = "0x60180C8")]
	[Address(RVA = "0x2641BC0", Offset = "0x2641BC0", VA = "0x2641BC0")]
	public TDiscreteEvent()
	{
	}
}
