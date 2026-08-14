using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000871")]
public class PetAnimComponentBase : MonoBehaviour, _Attribute
{
	[Token(Token = "0x40052F4")]
	public const bool PlayAnimSounds = false;

	[Token(Token = "0x40052F5")]
	[FieldOffset(Offset = "0xC")]
	public Animation AnimationComp;

	[Token(Token = "0x40052F6")]
	[FieldOffset(Offset = "0x10")]
	protected List<GameObject> JNEKNAICIMB;

	[Token(Token = "0x40052F7")]
	[FieldOffset(Offset = "0x14")]
	public ODFIIFHKNNG m_CurrentAnimType;

	[Token(Token = "0x40052F8")]
	[FieldOffset(Offset = "0x18")]
	public byte m_CurrentAnimIndex;

	[Token(Token = "0x40052F9")]
	[FieldOffset(Offset = "0x19")]
	private bool OKIDBOIGHOP;

	[Token(Token = "0x40052FA")]
	[FieldOffset(Offset = "0x1C")]
	public JFCGCIIOPDK m_AnimData;

	[Token(Token = "0x40052FB")]
	[FieldOffset(Offset = "0x20")]
	private CHGFLCMGBFP DHNLFGOEKKB;

	[Token(Token = "0x40052FC")]
	[FieldOffset(Offset = "0x24")]
	protected bool PEJBPBFNNOC;

	[Token(Token = "0x40052FD")]
	[FieldOffset(Offset = "0x25")]
	protected bool GODJPGPJHOO;

	[Token(Token = "0x40052FE")]
	[FieldOffset(Offset = "0x28")]
	protected string LICBEGEBKJK;

	[Token(Token = "0x40052FF")]
	[FieldOffset(Offset = "0x2C")]
	public bool EnableAsyncLoad;

	[Token(Token = "0x4005300")]
	[FieldOffset(Offset = "0x30")]
	protected ResourceID IHAFDPAIGHN;

	[Token(Token = "0x4005301")]
	[FieldOffset(Offset = "0x34")]
	private PetAnimResManager EFFLBAIKFND;

	[Token(Token = "0x17000416")]
	protected CHGFLCMGBFP FGMJKPEADMC
	{
		[Token(Token = "0x6003B53")]
		[Address(RVA = "0xBCBDEC", Offset = "0xBCBDEC", VA = "0xBCBDEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000417")]
	protected string MEEBFDJHBPN
	{
		[Token(Token = "0x6003B54")]
		[Address(RVA = "0xBCBE74", Offset = "0xBCBE74", VA = "0xBCBE74")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000418")]
	protected AnimationState JMBJLIIMALH
	{
		[Token(Token = "0x6003B55")]
		[Address(RVA = "0xBC7870", Offset = "0xBC7870", VA = "0xBC7870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003B42")]
	[Address(RVA = "0xBC7564", Offset = "0xBC7564", VA = "0xBC7564")]
	public PetAnimComponentBase()
	{
	}

	[Token(Token = "0x6003B43")]
	[Address(RVA = "0xBC96B4", Offset = "0xBC96B4", VA = "0xBC96B4", Slot = "5")]
	public virtual void Init(PetData AJKBOONEOAB, JFCGCIIOPDK HCDEFLCPPAI, List<PetActionData> IHOPFAJBOGO)
	{
	}

	[Token(Token = "0x6003B44")]
	[Address(RVA = "0xBCA45C", Offset = "0xBCA45C", VA = "0xBCA45C")]
	public void OnOwnerRoleChange(bool AHJAKPAEBIK)
	{
	}

	[Token(Token = "0x6003B45")]
	[Address(RVA = "0xBC93E0", Offset = "0xBC93E0", VA = "0xBC93E0", Slot = "6")]
	protected virtual void BMKPIJLAMAP(bool AHJAKPAEBIK, out bool AEODJOOCMBG, out bool OEJKAEIKGNM)
	{
	}

	[Token(Token = "0x6003B46")]
	[Address(RVA = "0xBCA50C", Offset = "0xBCA50C", VA = "0xBCA50C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6003B47")]
	[Address(RVA = "0xBCA74C", Offset = "0xBCA74C", VA = "0xBCA74C")]
	public void PreloadAnimClipInNeed(ResourceID KMIPBIGPDPI)
	{
	}

	[Token(Token = "0x6003B48")]
	[Address(RVA = "0xBC85E0", Offset = "0xBC85E0", VA = "0xBC85E0", Slot = "7")]
	public virtual bool PlayAnim(ODFIIFHKNNG OPJKJHBKLGN, byte LEPGEAPLMEO, bool ANDPBKOAIKH = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003B49")]
	[Address(RVA = "0xBCA874", Offset = "0xBCA874", VA = "0xBCA874")]
	private void JIHHMPJOGBH(CHGFLCMGBFP ILMPMIJAOKA)
	{
	}

	[Token(Token = "0x6003B4A")]
	[Address(RVA = "0xBCAB9C", Offset = "0xBCAB9C", VA = "0xBCAB9C")]
	private void JNKKMIHKANF(CHGFLCMGBFP ILMPMIJAOKA)
	{
	}

	[Token(Token = "0x6003B4B")]
	[Address(RVA = "0xBCAC14", Offset = "0xBCAC14", VA = "0xBCAC14")]
	private void MGAKKJPNHGK(CHGFLCMGBFP ILMPMIJAOKA)
	{
	}

	[Token(Token = "0x6003B4C")]
	[Address(RVA = "0xBCB164", Offset = "0xBCB164", VA = "0xBCB164")]
	private void LOJKHLHDIBA(CHGFLCMGBFP ILMPMIJAOKA)
	{
	}

	[Token(Token = "0x6003B4D")]
	[Address(RVA = "0xBCB204", Offset = "0xBCB204", VA = "0xBCB204")]
	protected void KIIJIPBNBAH()
	{
	}

	[Token(Token = "0x6003B4E")]
	[Address(RVA = "0xBCB3D0", Offset = "0xBCB3D0", VA = "0xBCB3D0")]
	protected void ELPJFEOGGIK(ODFIIFHKNNG OPJKJHBKLGN, CHGFLCMGBFP ILMPMIJAOKA)
	{
	}

	[Token(Token = "0x6003B4F")]
	[Address(RVA = "0xBCB4D4", Offset = "0xBCB4D4", VA = "0xBCB4D4")]
	protected void NIACEIIHKNE(AnimationClip MBAGEFEJDOA, bool ANDPBKOAIKH, float OJGNBJELDEM = 1f)
	{
	}

	[Token(Token = "0x6003B50")]
	[Address(RVA = "0xBC8E5C", Offset = "0xBC8E5C", VA = "0xBC8E5C")]
	public void PlayEffect(ResourceID IDNEFEOPGIF, Transform ACICLMFFFOA)
	{
	}

	[Token(Token = "0x6003B51")]
	[Address(RVA = "0xBCBC10", Offset = "0xBCBC10", VA = "0xBCBC10")]
	public void PlaySound(ResourceID IDNEFEOPGIF)
	{
	}

	[Token(Token = "0x6003B52")]
	protected T MAONFJNPNHJ<T>(ResourceID IDNEFEOPGIF) where T : class
	{
		return null;
	}

	[Token(Token = "0x6003B56")]
	[Address(RVA = "0xBC8414", Offset = "0xBC8414", VA = "0xBC8414")]
	public static bool IsLoop(ODFIIFHKNNG HLLGOKLLGEH)
	{
		return default(bool);
	}

	[Token(Token = "0x6003B57")]
	[Address(RVA = "0xBCBF8C", Offset = "0xBCBF8C", VA = "0xBCBF8C")]
	private void Update()
	{
	}

	[Token(Token = "0x6003B58")]
	[Address(RVA = "0xBC9468", Offset = "0xBC9468", VA = "0xBC9468", Slot = "8")]
	protected virtual void MKOCDHKHEJA()
	{
	}

	[Token(Token = "0x6003B59")]
	[Address(RVA = "0xBC94C0", Offset = "0xBC94C0", VA = "0xBC94C0", Slot = "9")]
	protected virtual void FOKKFMKKPFO(ResourceID IDNEFEOPGIF)
	{
	}

	[Token(Token = "0x6003B5A")]
	[Address(RVA = "0xBCC038", Offset = "0xBCC038", VA = "0xBCC038", Slot = "4")]
	public void OnReusableObjectRecycled(ResourceID ODNIHGABFJA, GameObject ECINOMEHBKA)
	{
	}

	[Token(Token = "0x6003B5B")]
	[Address(RVA = "0xBCC0C8", Offset = "0xBCC0C8", VA = "0xBCC0C8")]
	public void PlayAnimEffect(string HBFNCGONOPP)
	{
	}

	[Token(Token = "0x6003B5C")]
	[Address(RVA = "0xBCB820", Offset = "0xBCB820", VA = "0xBCB820")]
	public void PlayAnimEffect(ResourceID JPFKGCMPLLM, bool NACPFNLCILO = true)
	{
	}

	[Token(Token = "0x6003B5D")]
	[Address(RVA = "0xBC7934", Offset = "0xBC7934", VA = "0xBC7934")]
	protected void NDJDCOANLFI(Transform LHGLOHKNEPC, bool ELOELMEPFCN, bool AGJOOKMDHFO)
	{
	}

	[Token(Token = "0x6003B5E")]
	[Address(RVA = "0xBCC370", Offset = "0xBCC370", VA = "0xBCC370")]
	private void CFEDLCOEAGD(GameObject OMDFNKNJDII)
	{
	}

	[Token(Token = "0x6003B5F")]
	[Address(RVA = "0xBCC98C", Offset = "0xBCC98C", VA = "0xBCC98C")]
	private static bool CIHMHPHOMBL(GameObject OOMJGMJKNCK)
	{
		return default(bool);
	}

	[Token(Token = "0x6003B60")]
	[Address(RVA = "0xBC8098", Offset = "0xBC8098", VA = "0xBC8098")]
	protected void KNKEJDBKPMO()
	{
	}

	[Token(Token = "0x6003B61")]
	[Address(RVA = "0xBCCB2C", Offset = "0xBCCB2C", VA = "0xBCCB2C")]
	private static void KMPPEEOFJPA(string PHEJDNJONIL)
	{
	}
}
