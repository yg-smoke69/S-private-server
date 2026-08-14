using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001DFA")]
public class ParachuteStateParameter : ScriptableObject
{
	[Token(Token = "0x400BE05")]
	[FieldOffset(Offset = "0xC")]
	public ParachuteParam OnBoard;

	[Token(Token = "0x400BE06")]
	[FieldOffset(Offset = "0x10")]
	public ParachuteParam OnSkyDiving;

	[Token(Token = "0x400BE07")]
	[FieldOffset(Offset = "0x14")]
	public ParachuteParam OnSkySurfing;

	[Token(Token = "0x400BE08")]
	[FieldOffset(Offset = "0x18")]
	public ParachuteParam OnParachuting;

	[Token(Token = "0x400BE09")]
	[FieldOffset(Offset = "0x1C")]
	public ParachuteParam OnMountSkyDiving;

	[Token(Token = "0x400BE0A")]
	[FieldOffset(Offset = "0x20")]
	public ParachuteParam OnMountSkySurfing;

	[Token(Token = "0x400BE0B")]
	[FieldOffset(Offset = "0x24")]
	public ParachuteParam OnMountParachuting;

	[Token(Token = "0x400BE0C")]
	[FieldOffset(Offset = "0x28")]
	public ParachuteParam OnFlightRoam;

	[Token(Token = "0x400BE0D")]
	[FieldOffset(Offset = "0x2C")]
	public ParachuteParam OnBoardFlight;

	[Token(Token = "0x6008F89")]
	[Address(RVA = "0x1C79C94", Offset = "0x1C79C94", VA = "0x1C79C94")]
	public ParachuteStateParameter()
	{
	}
}
