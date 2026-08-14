using System.Collections.Generic;
using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C41")]
internal class TDiscreteEventSystem
{
	[Token(Token = "0x4019A3A")]
	[FieldOffset(Offset = "0x8")]
	private LinkedList<TDiscreteEvent> _events;

	[Token(Token = "0x60180D3")]
	[Address(RVA = "0x264203C", Offset = "0x264203C", VA = "0x264203C")]
	public TDiscreteEventSystem()
	{
	}

	[Token(Token = "0x60180D4")]
	[Address(RVA = "0x26420C8", Offset = "0x26420C8", VA = "0x26420C8")]
	public void Clear()
	{
	}

	[Token(Token = "0x60180D5")]
	[Address(RVA = "0x2642140", Offset = "0x2642140", VA = "0x2642140")]
	public void ClearAfter(TTimeAbs gameTime)
	{
	}

	[Token(Token = "0x60180D6")]
	[Address(RVA = "0x2642280", Offset = "0x2642280", VA = "0x2642280")]
	public EDiscreteEventSystemState Process(TTimeAbs gameTime, TAny workingData)
	{
		return default(EDiscreteEventSystemState);
	}

	[Token(Token = "0x60180D7")]
	[Address(RVA = "0x2642404", Offset = "0x2642404", VA = "0x2642404")]
	public bool PushEvent(TTimeAbs occurredTime, TDiscreteEvent.DiscreteEventAction action, int priority = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x60180D8")]
	[Address(RVA = "0x26426A4", Offset = "0x26426A4", VA = "0x26426A4")]
	public bool PushEvent(TTimeAbs currentTime, TTimeRel timeAfter, TDiscreteEvent.DiscreteEventAction action, int priority = 0)
	{
		return default(bool);
	}
}
