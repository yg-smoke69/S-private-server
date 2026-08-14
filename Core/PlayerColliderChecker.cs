using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001DCC")]
public class PlayerColliderChecker : MonoBehaviour
{
	[Token(Token = "0x2001DCD")]
	public enum HitPart
	{
		[Token(Token = "0x400BC9B")]
		Head,
		[Token(Token = "0x400BC9C")]
		Neck,
		[Token(Token = "0x400BC9D")]
		Chest,
		[Token(Token = "0x400BC9E")]
		Hips,
		[Token(Token = "0x400BC9F")]
		LeftArm,
		[Token(Token = "0x400BCA0")]
		LeftForeArm,
		[Token(Token = "0x400BCA1")]
		RightArm,
		[Token(Token = "0x400BCA2")]
		RightForeArm,
		[Token(Token = "0x400BCA3")]
		LeftUpLeg,
		[Token(Token = "0x400BCA4")]
		LeftLeg,
		[Token(Token = "0x400BCA5")]
		RightUpLeg,
		[Token(Token = "0x400BCA6")]
		RightLeg,
		[Token(Token = "0x400BCA7")]
		LeftFoot,
		[Token(Token = "0x400BCA8")]
		RightFoot,
		[Token(Token = "0x400BCA9")]
		LeftHand,
		[Token(Token = "0x400BCAA")]
		RightHand,
		[Token(Token = "0x400BCAB")]
		LeftClav,
		[Token(Token = "0x400BCAC")]
		RightClav,
		[Token(Token = "0x400BCAD")]
		NoFlag,
		[Token(Token = "0x400BCAE")]
		WeakPoint,
		[Token(Token = "0x400BCAF")]
		None
	}

	[Token(Token = "0x2001DCE")]
	public enum ViewBoxPart
	{
		[Token(Token = "0x400BCB1")]
		Chest,
		[Token(Token = "0x400BCB2")]
		Head,
		[Token(Token = "0x400BCB3")]
		Neck,
		[Token(Token = "0x400BCB4")]
		Arm,
		[Token(Token = "0x400BCB5")]
		ForeArm,
		[Token(Token = "0x400BCB6")]
		UpLeg,
		[Token(Token = "0x400BCB7")]
		Leg,
		[Token(Token = "0x400BCB8")]
		Foot
	}

	[Token(Token = "0x400BC99")]
	[FieldOffset(Offset = "0xC")]
	public List<ColliderInfo> m_colliderInfoList;

	[Token(Token = "0x6008E30")]
	[Address(RVA = "0x1E1DF4C", Offset = "0x1E1DF4C", VA = "0x1E1DF4C")]
	public PlayerColliderChecker()
	{
	}

	[Token(Token = "0x6008E31")]
	[Address(RVA = "0x1E1DF54", Offset = "0x1E1DF54", VA = "0x1E1DF54", Slot = "1")]
	~PlayerColliderChecker()
	{
	}

	[Token(Token = "0x6008E32")]
	[Address(RVA = "0x1E1DF5C", Offset = "0x1E1DF5C", VA = "0x1E1DF5C")]
	public void Start()
	{
	}

	[Token(Token = "0x6008E33")]
	[Address(RVA = "0x1E1DF60", Offset = "0x1E1DF60", VA = "0x1E1DF60")]
	public void ActiveColliders()
	{
	}

	[Token(Token = "0x6008E34")]
	[Address(RVA = "0x1E1E054", Offset = "0x1E1E054", VA = "0x1E1E054")]
	public void FindColliders()
	{
	}

	[Token(Token = "0x6008E35")]
	[Address(RVA = "0x1E1E380", Offset = "0x1E1E380", VA = "0x1E1E380")]
	public HitPart GetPartByCollider(Collider c)
	{
		return default(HitPart);
	}

	[Token(Token = "0x6008E36")]
	[Address(RVA = "0x1E1E4D8", Offset = "0x1E1E4D8", VA = "0x1E1E4D8")]
	public static int GetPartsMask(List<int> checkPartList)
	{
		return default(int);
	}
}
