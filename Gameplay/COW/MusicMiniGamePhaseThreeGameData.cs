using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200239F")]
public class MusicMiniGamePhaseThreeGameData
{
	[Token(Token = "0x400DDE2")]
	[FieldOffset(Offset = "0xC")]
	private float currentTime;

	[Token(Token = "0x400DDE3")]
	[FieldOffset(Offset = "0x10")]
	private int combo;

	[Token(Token = "0x14000006")]
	public event Action ComboChangeEvent
	{
		[Token(Token = "0x600C82B")]
		[Address(RVA = "0x2291618", Offset = "0x2291618", VA = "0x2291618")]
		add
		{
		}
		[Token(Token = "0x600C82C")]
		[Address(RVA = "0x2291774", Offset = "0x2291774", VA = "0x2291774")]
		remove
		{
		}
	}

	[Token(Token = "0x600C82A")]
	[Address(RVA = "0x2291610", Offset = "0x2291610", VA = "0x2291610")]
	public MusicMiniGamePhaseThreeGameData()
	{
	}

	[Token(Token = "0x600C82D")]
	[Address(RVA = "0x22918D0", Offset = "0x22918D0", VA = "0x22918D0")]
	public float GetCurrentTime()
	{
		return default(float);
	}

	[Token(Token = "0x600C82E")]
	[Address(RVA = "0x2291928", Offset = "0x2291928", VA = "0x2291928")]
	public void CurrentTimeChange(float delta)
	{
	}

	[Token(Token = "0x600C82F")]
	[Address(RVA = "0x2291998", Offset = "0x2291998", VA = "0x2291998")]
	public void InitCurrentTime()
	{
	}

	[Token(Token = "0x600C830")]
	[Address(RVA = "0x22919F4", Offset = "0x22919F4", VA = "0x22919F4")]
	public void ToneFinish(ToneCompleteType type)
	{
	}

	[Token(Token = "0x600C831")]
	[Address(RVA = "0x2291A88", Offset = "0x2291A88", VA = "0x2291A88")]
	public int GetCombo()
	{
		return default(int);
	}
}
