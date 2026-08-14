using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000425")]
internal class FollowCamera : CameraControllerBase
{
	[Token(Token = "0x2000426")]
	protected enum HOOLOBFAHMD
	{
		[Token(Token = "0x4003B6B")]
		NORMAL,
		[Token(Token = "0x4003B6C")]
		SNIPER,
		[Token(Token = "0x4003B6D")]
		INROOM
	}

	[Token(Token = "0x4003B31")]
	[FieldOffset(Offset = "0x0")]
	public static readonly float C_OFFSET_RIGHT;

	[Token(Token = "0x4003B32")]
	[FieldOffset(Offset = "0x4")]
	public static readonly float C_OFFSET_RIGHT_PASSENGER;

	[Token(Token = "0x4003B33")]
	[FieldOffset(Offset = "0x8")]
	public static readonly float C_OFFSET_UP;

	[Token(Token = "0x4003B34")]
	[FieldOffset(Offset = "0xC")]
	public static readonly float C_OFFSET_FOV;

	[Token(Token = "0x4003B35")]
	[FieldOffset(Offset = "0x10")]
	public static readonly float C_OFFSET_FOV_SKILLSHIELD;

	[Token(Token = "0x4003B36")]
	[FieldOffset(Offset = "0x14")]
	public static readonly float C_OFFSET_UP_PASSENGER;

	[Token(Token = "0x4003B37")]
	[FieldOffset(Offset = "0x18")]
	public static readonly float C_FOV_NORMAL;

	[Token(Token = "0x4003B38")]
	[FieldOffset(Offset = "0x24")]
	public float RightOffset;

	[Token(Token = "0x4003B39")]
	[FieldOffset(Offset = "0x28")]
	public float UpOffset;

	[Token(Token = "0x4003B3A")]
	[FieldOffset(Offset = "0x2C")]
	public float BackOffset;

	[Token(Token = "0x4003B3B")]
	[FieldOffset(Offset = "0x30")]
	public float FOVOffset;

	[Token(Token = "0x4003B3C")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly float IBLGJBBGNJI;

	[Token(Token = "0x4003B3D")]
	[FieldOffset(Offset = "0x20")]
	public static readonly float OFFSET_FOR_NORMAL;

	[Token(Token = "0x4003B3E")]
	[FieldOffset(Offset = "0x24")]
	private static readonly float NFADHEDKHOA;

	[Token(Token = "0x4003B3F")]
	[FieldOffset(Offset = "0x28")]
	private static readonly float IGNIJKDEDGB;

	[Token(Token = "0x4003B40")]
	[FieldOffset(Offset = "0x2C")]
	private static readonly float AHBKACEAEAI;

	[Token(Token = "0x4003B41")]
	[FieldOffset(Offset = "0x30")]
	private static readonly float MEIPCEKBOGM;

	[Token(Token = "0x4003B42")]
	[FieldOffset(Offset = "0x34")]
	private static readonly float BGHIEEFOAIM;

	[Token(Token = "0x4003B43")]
	[FieldOffset(Offset = "0x38")]
	private static readonly float DKFAAAPPBEB;

	[Token(Token = "0x4003B44")]
	[FieldOffset(Offset = "0x3C")]
	private static readonly float BGCJADIPJJA;

	[Token(Token = "0x4003B45")]
	[FieldOffset(Offset = "0x40")]
	private static readonly float DOEDJNPOGFG;

	[Token(Token = "0x4003B46")]
	[FieldOffset(Offset = "0x44")]
	private static readonly float AHOBNIHOAPC;

	[Token(Token = "0x4003B47")]
	[FieldOffset(Offset = "0x48")]
	private static readonly float LACFBGPNOJI;

	[Token(Token = "0x4003B48")]
	[FieldOffset(Offset = "0x4C")]
	public static readonly float C_OFFSET_UP_SKILLL_SHIELD;

	[Token(Token = "0x4003B49")]
	[FieldOffset(Offset = "0x50")]
	public static readonly float C_OFFSET_BACK_SKILLL_SHIELD;

	[Token(Token = "0x4003B4A")]
	[FieldOffset(Offset = "0x54")]
	public static readonly float BackOffsetInRoom;

	[Token(Token = "0x4003B4B")]
	[FieldOffset(Offset = "0x34")]
	public float RightOffsetInRoom;

	[Token(Token = "0x4003B4C")]
	[FieldOffset(Offset = "0x58")]
	private static readonly float IEKAMAGDCAP;

	[Token(Token = "0x4003B4D")]
	[FieldOffset(Offset = "0x38")]
	public float UpOffsetInCreep;

	[Token(Token = "0x4003B4E")]
	[FieldOffset(Offset = "0x3C")]
	public float UpOffsetSurf;

	[Token(Token = "0x4003B4F")]
	[FieldOffset(Offset = "0x40")]
	public float UpOffsetCatapult;

	[Token(Token = "0x4003B50")]
	[FieldOffset(Offset = "0x44")]
	public float UpOffsetOnChair;

	[Token(Token = "0x4003B51")]
	[FieldOffset(Offset = "0x48")]
	public float UpOffsetCannon;

	[Token(Token = "0x4003B52")]
	[FieldOffset(Offset = "0x4C")]
	public float m_RightOffset;

	[Token(Token = "0x4003B53")]
	[FieldOffset(Offset = "0x50")]
	public float m_UpOffset;

	[Token(Token = "0x4003B54")]
	[FieldOffset(Offset = "0x54")]
	private float NENDPNCDFLJ;

	[Token(Token = "0x4003B55")]
	[FieldOffset(Offset = "0x58")]
	protected float ANOEPCDMIMF;

	[Token(Token = "0x4003B56")]
	[FieldOffset(Offset = "0x5C")]
	public bool IsOnHead;

	[Token(Token = "0x4003B57")]
	[FieldOffset(Offset = "0x5D")]
	public bool NeedUpdate;

	[NonSerialized]
	[Token(Token = "0x4003B58")]
	[FieldOffset(Offset = "0x60")]
	public float CameraCollisionOffsetRight;

	[NonSerialized]
	[Token(Token = "0x4003B59")]
	[FieldOffset(Offset = "0x64")]
	public float CameraCollisionOffsetBack;

	[Token(Token = "0x4003B5A")]
	[FieldOffset(Offset = "0x68")]
	private float BEEBPJCCPJA;

	[Token(Token = "0x4003B5B")]
	[FieldOffset(Offset = "0x6C")]
	protected MADMMIICBNN GKFIJMEHHII;

	[Token(Token = "0x4003B5C")]
	[FieldOffset(Offset = "0x70")]
	private float JBFNOHNKPMK;

	[Token(Token = "0x4003B5D")]
	[FieldOffset(Offset = "0x74")]
	private bool LIIKGEJIAFB;

	[Token(Token = "0x4003B5E")]
	[FieldOffset(Offset = "0x75")]
	private bool MNFNCFKKAKE;

	[Token(Token = "0x4003B5F")]
	[FieldOffset(Offset = "0x78")]
	private float PNGODAHFIHG;

	[Token(Token = "0x4003B60")]
	[FieldOffset(Offset = "0x7C")]
	protected HOOLOBFAHMD EHPEPFOOGLA;

	[Token(Token = "0x4003B61")]
	[FieldOffset(Offset = "0x80")]
	protected HOOLOBFAHMD MFDCIMGFHCC;

	[Token(Token = "0x4003B62")]
	[FieldOffset(Offset = "0x84")]
	protected Vector3 BKLGJDBCPKK;

	[Token(Token = "0x4003B63")]
	[FieldOffset(Offset = "0x90")]
	protected Vector3 NIHLMKIBPIM;

	[Token(Token = "0x4003B64")]
	[FieldOffset(Offset = "0x9C")]
	protected Vector3 HMNBPPHGGMI;

	[Token(Token = "0x4003B65")]
	[FieldOffset(Offset = "0xA8")]
	private LMJECBDBEKC MAJOLAGLFIB;

	[Token(Token = "0x4003B66")]
	[FieldOffset(Offset = "0xAC")]
	private float BDGIBHOLGCB;

	[Token(Token = "0x4003B67")]
	[FieldOffset(Offset = "0xB0")]
	private float IEPGDDKAAKF;

	[Token(Token = "0x4003B68")]
	[FieldOffset(Offset = "0xB4")]
	private float DMMIHMENJAP;

	[Token(Token = "0x4003B69")]
	[FieldOffset(Offset = "0xB8")]
	private float FPOLKCPLOLI;

	[Token(Token = "0x170001C8")]
	protected virtual float OMEHCMMOBII
	{
		[Token(Token = "0x6001480")]
		[Address(RVA = "0x1DA4454", Offset = "0x1DA4454", VA = "0x1DA4454", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170001C9")]
	public virtual float EPINKPIGDFC
	{
		[Token(Token = "0x6001481")]
		[Address(RVA = "0x1DA44AC", Offset = "0x1DA44AC", VA = "0x1DA44AC", Slot = "8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170001CA")]
	protected Player GEMHAAHJBBD
	{
		[Token(Token = "0x6001482")]
		[Address(RVA = "0x1DA4100", Offset = "0x1DA4100", VA = "0x1DA4100")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001CB")]
	public Vector3 EIBNHAJBEFK
	{
		[Token(Token = "0x600148C")]
		[Address(RVA = "0x1DA7498", Offset = "0x1DA7498", VA = "0x1DA7498")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x170001CC")]
	public bool GEGOCLDJILI
	{
		[Token(Token = "0x600148F")]
		[Address(RVA = "0x1DA778C", Offset = "0x1DA778C", VA = "0x1DA778C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600147C")]
	[Address(RVA = "0x1DA1438", Offset = "0x1DA1438", VA = "0x1DA1438")]
	public FollowCamera()
	{
	}

	[Token(Token = "0x600147D")]
	[Address(RVA = "0x1DA3CC0", Offset = "0x1DA3CC0", VA = "0x1DA3CC0")]
	private void Start()
	{
	}

	[Token(Token = "0x600147E")]
	[Address(RVA = "0x1DA3D84", Offset = "0x1DA3D84", VA = "0x1DA3D84")]
	public void SetOffestRightAndBack()
	{
	}

	[Token(Token = "0x600147F")]
	[Address(RVA = "0x1DA42B0", Offset = "0x1DA42B0", VA = "0x1DA42B0")]
	public void SetOffestFOV()
	{
	}

	[Token(Token = "0x6001483")]
	[Address(RVA = "0x1DA4AAC", Offset = "0x1DA4AAC", VA = "0x1DA4AAC")]
	private bool FCKAGLMJNPP(Player KAEHJEGFKBL, bool ELOJDGBLLND)
	{
		return default(bool);
	}

	[Token(Token = "0x6001484")]
	[Address(RVA = "0x1DA4E08", Offset = "0x1DA4E08", VA = "0x1DA4E08", Slot = "9")]
	protected virtual float LJOOMGDEHPL(Player KAEHJEGFKBL)
	{
		return default(float);
	}

	[Token(Token = "0x6001485")]
	[Address(RVA = "0x1DA553C", Offset = "0x1DA553C", VA = "0x1DA553C", Slot = "10")]
	protected virtual float HODILECKNDD(Player KAEHJEGFKBL, Vector3 HLAONGBLDJH, Vector3 ACLOJCLLLDK)
	{
		return default(float);
	}

	[Token(Token = "0x6001486")]
	[Address(RVA = "0x1DA59B4", Offset = "0x1DA59B4", VA = "0x1DA59B4", Slot = "11")]
	protected virtual float MFLHACPEBFK(Player KAEHJEGFKBL)
	{
		return default(float);
	}

	[Token(Token = "0x6001487")]
	[Address(RVA = "0x1DA5CB4", Offset = "0x1DA5CB4", VA = "0x1DA5CB4")]
	private float MPFMAHIILHK(Vector3 PFAPJJODMCM, Vector3 NLICKABMANM, float MLGKHMFMJHP, float IMMGILEIOHJ, [Optional] string HOEHMBENOFM)
	{
		return default(float);
	}

	[Token(Token = "0x6001488")]
	[Address(RVA = "0x1DA5EE0", Offset = "0x1DA5EE0", VA = "0x1DA5EE0")]
	private bool JOPPEPFPGIE(MADMMIICBNN PKAHCEKFHIA, string CIHEIOODMLM)
	{
		return default(bool);
	}

	[Token(Token = "0x6001489")]
	[Address(RVA = "0x1DA6088", Offset = "0x1DA6088", VA = "0x1DA6088")]
	protected float BLIPPMJEIKK(Vector3 PFAPJJODMCM, Vector3 NLICKABMANM, bool AKDLFENPKJE, float OOCLKIAANIO, [Optional] string HOEHMBENOFM)
	{
		return default(float);
	}

	[Token(Token = "0x600148A")]
	[Address(RVA = "0x1DA6EB8", Offset = "0x1DA6EB8", VA = "0x1DA6EB8")]
	private Quaternion KGMEGHAAHLC(Quaternion NONJGMKLNHF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}

	[Token(Token = "0x600148B")]
	[Address(RVA = "0x1DA1C78", Offset = "0x1DA1C78", VA = "0x1DA1C78", Slot = "4")]
	protected override void IMEHMEOBENM()
	{
	}

	[Token(Token = "0x600148D")]
	[Address(RVA = "0x1DA7508", Offset = "0x1DA7508", VA = "0x1DA7508", Slot = "5")]
	protected override void PCGJKJBMAJM()
	{
	}

	[Token(Token = "0x600148E")]
	[Address(RVA = "0x1DA16E4", Offset = "0x1DA16E4", VA = "0x1DA16E4", Slot = "6")]
	public override void OnCameraChanged()
	{
	}

	[Token(Token = "0x6001490")]
	[Address(RVA = "0x1DA7804", Offset = "0x1DA7804", VA = "0x1DA7804")]
	public void SetZoomDest(float LEBOAIEJCPJ, float EPJJEPNDOKO = 0f)
	{
	}

	[Token(Token = "0x6001491")]
	[Address(RVA = "0x1DA7960", Offset = "0x1DA7960", VA = "0x1DA7960")]
	public void SetZoomDestDefault(float OJGNBJELDEM = 0f)
	{
	}

	[Token(Token = "0x6001492")]
	[Address(RVA = "0x1DA73BC", Offset = "0x1DA73BC", VA = "0x1DA73BC")]
	protected void GHKLCKNMAJL()
	{
	}

	[Token(Token = "0x6001493")]
	[Address(RVA = "0x1DA5314", Offset = "0x1DA5314", VA = "0x1DA5314")]
	private float KFMHKBOMNGL(float CJFMKGCHKJJ, float LFDIKANPNOE)
	{
		return default(float);
	}

	[Token(Token = "0x6001494")]
	[Address(RVA = "0x1DA7B50", Offset = "0x1DA7B50", VA = "0x1DA7B50")]
	public float GetDistanceToTarget()
	{
		return default(float);
	}

	[Token(Token = "0x6001495")]
	[Address(RVA = "0x1DA7D5C", Offset = "0x1DA7D5C", VA = "0x1DA7D5C")]
	public float GetMaxDistanceToTarget()
	{
		return default(float);
	}

	[Token(Token = "0x6001496")]
	[Address(RVA = "0x1DA7EA8", Offset = "0x1DA7EA8", VA = "0x1DA7EA8")]
	public void BeginLerpBackOffset(float FILCCIFMJGA, float NHAAMFDOKII = -1f)
	{
	}

	[Token(Token = "0x6001497")]
	[Address(RVA = "0x1DA802C", Offset = "0x1DA802C", VA = "0x1DA802C")]
	public void ForceUpdateCamera()
	{
	}

	[Token(Token = "0x6001499")]
	[Address(RVA = "0x1DA9358", Offset = "0x1DA9358", VA = "0x1DA9358")]
	public void _003C_003EiFixBaseProxy_OnCameraChanged()
	{
	}

	[Token(Token = "0x600149A")]
	[Address(RVA = "0x1DA9360", Offset = "0x1DA9360", VA = "0x1DA9360")]
	public void _003C_003EiFixBaseProxy_IMEHMEOBENM()
	{
	}

	[Token(Token = "0x600149B")]
	[Address(RVA = "0x1DA9368", Offset = "0x1DA9368", VA = "0x1DA9368")]
	public void _003C_003EiFixBaseProxy_PCGJKJBMAJM()
	{
	}
}
