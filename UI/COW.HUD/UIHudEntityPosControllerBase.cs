using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.HUD;

[Token(Token = "0x20028AD")]
public abstract class UIHudEntityPosControllerBase : UIBaseController
{
	[Token(Token = "0x20028AE")]
	protected enum MPOLJMJBFCB
	{
		[Token(Token = "0x400FA56")]
		NONE,
		[Token(Token = "0x400FA57")]
		UP,
		[Token(Token = "0x400FA58")]
		DOWN,
		[Token(Token = "0x400FA59")]
		LEFT,
		[Token(Token = "0x400FA5A")]
		RIGHT
	}

	[Token(Token = "0x400FA41")]
	[FieldOffset(Offset = "0x28")]
	protected Entity NHPLIOAJEEL;

	[Token(Token = "0x400FA42")]
	[FieldOffset(Offset = "0x2C")]
	internal Player NJMDHHGDNPJ;

	[Token(Token = "0x400FA43")]
	[FieldOffset(Offset = "0x30")]
	protected GameObject IPEKPIAIBAM;

	[Token(Token = "0x400FA44")]
	[FieldOffset(Offset = "0x34")]
	protected GameObject ONGAGPJKJME;

	[Token(Token = "0x400FA45")]
	[FieldOffset(Offset = "0x38")]
	protected UILabel CDKLCJAOKOF;

	[Token(Token = "0x400FA46")]
	[FieldOffset(Offset = "0x3C")]
	protected UISprite EJPGLCFIJHE;

	[Token(Token = "0x400FA47")]
	[FieldOffset(Offset = "0x40")]
	protected UISprite NIKKIDDEOJA;

	[Token(Token = "0x400FA48")]
	[FieldOffset(Offset = "0x44")]
	protected UISprite BOMIHIAOPIN;

	[Token(Token = "0x400FA49")]
	[FieldOffset(Offset = "0x48")]
	protected UISprite EDEJMMCCMNI;

	[Token(Token = "0x400FA4A")]
	[FieldOffset(Offset = "0x4C")]
	protected bool GKMBAMFNKOM;

	[Token(Token = "0x400FA4B")]
	[FieldOffset(Offset = "0x50")]
	protected float DHPPBAALFDG;

	[Token(Token = "0x400FA4C")]
	[FieldOffset(Offset = "0x54")]
	private StringBuilder FPGGDNNFGDM;

	[Token(Token = "0x400FA4D")]
	[FieldOffset(Offset = "0x58")]
	private float HPFICPAOHGC;

	[Token(Token = "0x400FA4E")]
	[FieldOffset(Offset = "0x5C")]
	private Vector2 DLHHKKNNJDI;

	[Token(Token = "0x400FA4F")]
	[FieldOffset(Offset = "0x64")]
	private Vector2 NJKKDHPLJHK;

	[Token(Token = "0x400FA50")]
	[FieldOffset(Offset = "0x6C")]
	private int GFAFNAIDBKD;

	[Token(Token = "0x400FA51")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 HFCCJFPPCCD;

	[Token(Token = "0x400FA52")]
	[FieldOffset(Offset = "0x7C")]
	private float FJJOGKFIBCA;

	[Token(Token = "0x400FA53")]
	[FieldOffset(Offset = "0x80")]
	protected bool JCOMMBJACCF;

	[Token(Token = "0x400FA54")]
	[FieldOffset(Offset = "0x81")]
	protected bool DIPOLCAMKPA;

	[Token(Token = "0x17001206")]
	protected bool IJGFNLICGGC
	{
		[Token(Token = "0x600FFAD")]
		[Address(RVA = "0x1216620", Offset = "0x1216620", VA = "0x1216620")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600FFAC")]
	[Address(RVA = "0x1216594", Offset = "0x1216594", VA = "0x1216594")]
	protected UIHudEntityPosControllerBase()
	{
	}

	[Token(Token = "0x600FFAE")]
	[Address(RVA = "0x12166AC", Offset = "0x12166AC", VA = "0x12166AC", Slot = "31")]
	protected virtual void UpdateTargetPlayer()
	{
	}

	[Token(Token = "0x600FFAF")]
	[Address(RVA = "0x1216730", Offset = "0x1216730", VA = "0x1216730", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FFB0")]
	[Address(RVA = "0x12167E4", Offset = "0x12167E4", VA = "0x12167E4", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600FFB1")]
	[Address(RVA = "0x1216E14", Offset = "0x1216E14", VA = "0x1216E14", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FFB2")]
	[Address(RVA = "0x1216E78", Offset = "0x1216E78", VA = "0x1216E78")]
	private void HLPCOLLPANJ()
	{
	}

	[Token(Token = "0x600FFB3")]
	[Address(RVA = "0x1216E54", Offset = "0x1216E54", VA = "0x1216E54")]
	private void NNEPBFMNLGC()
	{
	}

	[Token(Token = "0x600FFB4")]
	[Address(RVA = "0x1216E9C", Offset = "0x1216E9C", VA = "0x1216E9C", Slot = "32")]
	protected virtual void OnRegisterEvents()
	{
	}

	[Token(Token = "0x600FFB5")]
	[Address(RVA = "0x1216EA0", Offset = "0x1216EA0", VA = "0x1216EA0", Slot = "33")]
	protected virtual void OnUnRegisterEvents()
	{
	}

	[Token(Token = "0x600FFB6")]
	[Address(RVA = "0x1216EA4", Offset = "0x1216EA4", VA = "0x1216EA4", Slot = "34")]
	public virtual void BindTarget(Entity HGMBMICDALC)
	{
	}

	[Token(Token = "0x600FFB7")]
	[Address(RVA = "0x1216F18", Offset = "0x1216F18", VA = "0x1216F18", Slot = "35")]
	public virtual void UnBindTarget()
	{
	}

	[Token(Token = "0x600FFB8")]
	[Address(RVA = "0x1216F94", Offset = "0x1216F94", VA = "0x1216F94", Slot = "36")]
	public virtual void RecycleUI()
	{
	}

	[Token(Token = "0x600FFB9")]
	[Address(RVA = "0x1217084", Offset = "0x1217084", VA = "0x1217084")]
	protected void LateUpdate()
	{
	}

	[Token(Token = "0x600FFBA")]
	[Address(RVA = "0x12170B4", Offset = "0x12170B4", VA = "0x12170B4", Slot = "37")]
	protected virtual void LEBFKPDMKIB()
	{
	}

	[Token(Token = "0x600FFBB")]
	[Address(RVA = "0x1217108", Offset = "0x1217108", VA = "0x1217108")]
	protected void AGKHLFMFPEC()
	{
	}

	[Token(Token = "0x600FFBC")]
	[Address(RVA = "0x1217740", Offset = "0x1217740", VA = "0x1217740")]
	protected void JMBLBGGJLAJ(Vector3 MAGHFOEPFOD)
	{
	}

	[Token(Token = "0x600FFBD")]
	[Address(RVA = "0x1217540", Offset = "0x1217540", VA = "0x1217540")]
	protected void COICHJFJCGE(Vector3 MAGHFOEPFOD)
	{
	}

	[Token(Token = "0x600FFBE")]
	[Address(RVA = "0x12178A0", Offset = "0x12178A0", VA = "0x12178A0")]
	protected void IOBLLMEIDGJ(Vector3 MAGHFOEPFOD)
	{
	}

	[Token(Token = "0x600FFBF")]
	[Address(RVA = "0x12172C4", Offset = "0x12172C4", VA = "0x12172C4")]
	protected void EIAGEOPAJMG()
	{
	}

	[Token(Token = "0x600FFC0")]
	[Address(RVA = "0x1216A74", Offset = "0x1216A74", VA = "0x1216A74")]
	protected Vector2 BFODICKPEDP(MonoBehaviour AAFBIANMEAL, MonoBehaviour KENDCFNPDCE, bool ECJDGHIHIGO)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x600FFC1")]
	[Address(RVA = "0x1217CC0", Offset = "0x1217CC0", VA = "0x1217CC0", Slot = "38")]
	protected virtual Vector3 GetRefPos(Entity HGMBMICDALC)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600FFC2")]
	[Address(RVA = "0x1217A20", Offset = "0x1217A20", VA = "0x1217A20")]
	protected void IGBJJJEGGJO(MPOLJMJBFCB COCOBLKAIMJ)
	{
	}

	[Token(Token = "0x600FFC3")]
	[Address(RVA = "0x1217D20", Offset = "0x1217D20", VA = "0x1217D20")]
	protected void PHADFGMNBNO(MonoBehaviour ECINOMEHBKA, bool GIKMGIJCDOP)
	{
	}
}
