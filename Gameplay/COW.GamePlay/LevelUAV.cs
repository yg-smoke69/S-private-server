using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20006D2")]
internal class LevelUAV : AttackableEntity
{
	[Token(Token = "0x20006D3")]
	protected class HHCBNAPCKHF : ShadowStateBase
	{
		[Token(Token = "0x4004AEF")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 JHJLNLCEGOG;

		[Token(Token = "0x4004AF0")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 PGDEDHFOMCN;

		[Token(Token = "0x4004AF1")]
		[FieldOffset(Offset = "0x28")]
		public Quaternion FBMPKHMBHAM;

		[Token(Token = "0x4004AF2")]
		[FieldOffset(Offset = "0x38")]
		public Quaternion BPLOAFBIHJL;

		[Token(Token = "0x6002BA5")]
		[Address(RVA = "0x242CB74", Offset = "0x242CB74", VA = "0x242CB74")]
		public HHCBNAPCKHF()
		{
		}
	}

	[Token(Token = "0x4004AE1")]
	[FieldOffset(Offset = "0x48")]
	protected uint KINJCKMOGIM;

	[Token(Token = "0x4004AE2")]
	[FieldOffset(Offset = "0x4C")]
	protected HHCBNAPCKHF PLGAAJABBHA;

	[Token(Token = "0x4004AE3")]
	[FieldOffset(Offset = "0x50")]
	public uint UAV_ID;

	[Token(Token = "0x4004AE4")]
	[FieldOffset(Offset = "0x54")]
	public GameObject m_ModelObject;

	[Token(Token = "0x4004AE5")]
	[FieldOffset(Offset = "0x58")]
	public Animation m_Animation;

	[Token(Token = "0x4004AE6")]
	[FieldOffset(Offset = "0x5C")]
	private bool NLPCOCLENFL;

	[Token(Token = "0x4004AE7")]
	[FieldOffset(Offset = "0x60")]
	public IHAAMHPPLMG m_OwnerID;

	[Token(Token = "0x4004AE8")]
	[FieldOffset(Offset = "0x78")]
	public uint m_UAVItemID;

	[Token(Token = "0x4004AE9")]
	public const string IdleAnimName = "Idle";

	[Token(Token = "0x4004AEA")]
	public const string FlyAnimName = "Fly_F";

	[Token(Token = "0x4004AEB")]
	public const string ANIM_SPEED_PARAM = "Speed";

	[Token(Token = "0x4004AEC")]
	[FieldOffset(Offset = "0x7C")]
	public byte m_IconStyle;

	[Token(Token = "0x4004AED")]
	[FieldOffset(Offset = "0x80")]
	private string EAFDKBHKNHO;

	[Token(Token = "0x4004AEE")]
	[FieldOffset(Offset = "0x84")]
	private GameObject AONHDPFEMIO;

	[Token(Token = "0x6002B9A")]
	[Address(RVA = "0x242CA84", Offset = "0x242CA84", VA = "0x242CA84")]
	public LevelUAV()
	{
	}

	[Token(Token = "0x6002B9B")]
	[Address(RVA = "0x242CB7C", Offset = "0x242CB7C", VA = "0x242CB7C", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002B9C")]
	[Address(RVA = "0x242CBD4", Offset = "0x242CBD4", VA = "0x242CBD4")]
	public void Init(uint BBMNCELOMAI, uint AOGJNMFCIPL = 0u, uint CJDMCMOODAH = 0u, byte DFHOODHODEH = 0)
	{
	}

	[Token(Token = "0x6002B9D")]
	[Address(RVA = "0x242D128", Offset = "0x242D128", VA = "0x242D128")]
	public void PushSyncState(Vector3 MLCIHBOHEHE, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x6002B9E")]
	[Address(RVA = "0x242D420", Offset = "0x242D420", VA = "0x242D420", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002B9F")]
	[Address(RVA = "0x242DBF0", Offset = "0x242DBF0", VA = "0x242DBF0", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint GGIDKOBOJBB = 0u)
	{
	}

	[Token(Token = "0x6002BA0")]
	[Address(RVA = "0x242E074", Offset = "0x242E074", VA = "0x242E074")]
	public void Dead(int PLCOGJHIJID)
	{
	}

	[Token(Token = "0x6002BA1")]
	[Address(RVA = "0x242DAC0", Offset = "0x242DAC0", VA = "0x242DAC0")]
	public void UpdateAnim(float OJGNBJELDEM)
	{
	}

	[Token(Token = "0x6002BA2")]
	[Address(RVA = "0x242EB90", Offset = "0x242EB90", VA = "0x242EB90")]
	private CommonParticleEffect FLBGIABDFNL(ResourceID GJMJJFAOBEL, ResourceID DDDJHDHBFJB)
	{
		return null;
	}

	[Token(Token = "0x6002BA3")]
	[Address(RVA = "0x242EFB4", Offset = "0x242EFB4", VA = "0x242EFB4")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x6002BA4")]
	[Address(RVA = "0x242EFBC", Offset = "0x242EFBC", VA = "0x242EFBC")]
	public void _003C_003EiFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List<float> P2, uint P3)
	{
	}
}
