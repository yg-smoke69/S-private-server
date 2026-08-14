using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200046B")]
public class SingerBDebugTool : MonoBehaviour
{
	[Token(Token = "0x4003CDF")]
	[FieldOffset(Offset = "0xC")]
	public List<Transform> SpawnPoints;

	[Token(Token = "0x4003CE0")]
	[FieldOffset(Offset = "0x10")]
	public float CallDanceOneTime;

	[Token(Token = "0x4003CE1")]
	[FieldOffset(Offset = "0x14")]
	public float CallDanceTwoTime;

	[Token(Token = "0x4003CE2")]
	[FieldOffset(Offset = "0x18")]
	public float CallDanceThreeTime;

	[Token(Token = "0x4003CE3")]
	[FieldOffset(Offset = "0x1C")]
	private int pointIndex;

	[Token(Token = "0x600162E")]
	[Address(RVA = "0x21CE6BC", Offset = "0x21CE6BC", VA = "0x21CE6BC")]
	public SingerBDebugTool()
	{
	}

	[Token(Token = "0x600162F")]
	[Address(RVA = "0x21CE6E8", Offset = "0x21CE6E8", VA = "0x21CE6E8")]
	public void TeleportToNextSpawnPoint()
	{
	}

	[Token(Token = "0x6001630")]
	[Address(RVA = "0x21CE858", Offset = "0x21CE858", VA = "0x21CE858")]
	private void TeleportToPoint(Vector3 targetPos, Quaternion targetRot)
	{
	}

	[Token(Token = "0x6001631")]
	[Address(RVA = "0x21CEACC", Offset = "0x21CEACC", VA = "0x21CEACC")]
	private void Update()
	{
	}

	[Token(Token = "0x6001632")]
	[Address(RVA = "0x21CF2B8", Offset = "0x21CF2B8", VA = "0x21CF2B8")]
	private void DebugCallDance(int index, float callTime)
	{
	}

	[Token(Token = "0x6001633")]
	[Address(RVA = "0x21CF4AC", Offset = "0x21CF4AC", VA = "0x21CF4AC")]
	private void DebugSwitchToStarFalling()
	{
	}

	[Token(Token = "0x6001634")]
	[Address(RVA = "0x21CEFA4", Offset = "0x21CEFA4", VA = "0x21CEFA4")]
	private void DebugBeginFreeStarFalling()
	{
	}

	[Token(Token = "0x6001635")]
	[Address(RVA = "0x21CF040", Offset = "0x21CF040", VA = "0x21CF040")]
	private void DebugGetOnFlight()
	{
	}

	[Token(Token = "0x6001636")]
	[Address(RVA = "0x21CF170", Offset = "0x21CF170", VA = "0x21CF170")]
	private void DebugFollowFlightToSkateBoard()
	{
	}

	[Token(Token = "0x6001637")]
	[Address(RVA = "0x21CF214", Offset = "0x21CF214", VA = "0x21CF214")]
	private void DebugSketaBoardToFollowFlight()
	{
	}
}
