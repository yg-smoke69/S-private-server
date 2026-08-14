using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000AE4")]
public class SceneEditObjectBase : MonoBehaviour
{
	[Token(Token = "0x4005EA9")]
	[FieldOffset(Offset = "0xC")]
	protected int IKOBGEEODIM;

	[Token(Token = "0x4005EAA")]
	[FieldOffset(Offset = "0x10")]
	protected uint CKOFIIANAPN;

	[Token(Token = "0x4005EAB")]
	[FieldOffset(Offset = "0x14")]
	protected Transform EEOCPFHNDEN;

	[Token(Token = "0x4005EAC")]
	[FieldOffset(Offset = "0x18")]
	protected SceneEditPrefabConfigData OHFBJJBNGLC;

	[Token(Token = "0x4005EAD")]
	[FieldOffset(Offset = "0x1C")]
	protected GameObject BKFECPOCPMK;

	[Token(Token = "0x4005EAE")]
	[FieldOffset(Offset = "0x20")]
	protected GameObject JGFAMBIMGMP;

	[Token(Token = "0x4005EAF")]
	[FieldOffset(Offset = "0x24")]
	private List<Collider> MIEDNCEEKGK;

	[Token(Token = "0x4005EB0")]
	[FieldOffset(Offset = "0x28")]
	private List<SceneEditObjectBase> ONDLPOFEKLF;

	[Token(Token = "0x4005EB1")]
	[FieldOffset(Offset = "0x2C")]
	private bool HJOFMGJEOCD;

	[Token(Token = "0x4005EB2")]
	[FieldOffset(Offset = "0x30")]
	private int CKMOHGBDAED;

	[Token(Token = "0x4005EB3")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 m_GroupToSelectedDis;

	[Token(Token = "0x4005EB4")]
	[FieldOffset(Offset = "0x40")]
	private GameObject CFJKKBNCHEN;

	[Token(Token = "0x4005EB5")]
	[FieldOffset(Offset = "0x44")]
	public IOBOKBBLLBI ObjectColor;

	[Token(Token = "0x4005EB6")]
	[FieldOffset(Offset = "0x48")]
	private SceneEditObjectBase GPJOAIDJOEM;

	[Token(Token = "0x4005EB7")]
	[FieldOffset(Offset = "0x4C")]
	private List<Renderer> JAIFBIIOLFB;

	[Token(Token = "0x4005EB8")]
	[FieldOffset(Offset = "0x50")]
	private LevelTriggerFountain KJJDFLLPHLF;

	[Token(Token = "0x4005EB9")]
	[FieldOffset(Offset = "0x54")]
	private MusicElement BHEIBODDLFL;

	[Token(Token = "0x4005EBA")]
	[FieldOffset(Offset = "0x58")]
	public string LogicEntityID;

	[Token(Token = "0x4005EBB")]
	[FieldOffset(Offset = "0x5C")]
	private string PCCFEIGOMLN;

	[Token(Token = "0x4005EBC")]
	[FieldOffset(Offset = "0x60")]
	public bool IsCustomizedNameChanged;

	[Token(Token = "0x4005EBD")]
	[FieldOffset(Offset = "0x64")]
	public uint ResetEveryRound;

	[Token(Token = "0x4005EBE")]
	[FieldOffset(Offset = "0x68")]
	private Bounds BPAPGHNBOPH;

	[Token(Token = "0x4005EBF")]
	[FieldOffset(Offset = "0x80")]
	private bool JDLJDHMDKII;

	[Token(Token = "0x4005EC0")]
	[FieldOffset(Offset = "0x84")]
	private Dictionary<Renderer, Material[]> INLJLKCGHLA;

	[Token(Token = "0x4005EC1")]
	[FieldOffset(Offset = "0x88")]
	private Material AKKDOGIGLNE;

	[Token(Token = "0x170006AD")]
	public int OLNEAONMMDO
	{
		[Token(Token = "0x60053BA")]
		[Address(RVA = "0x1D664C8", Offset = "0x1D664C8", VA = "0x1D664C8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006AE")]
	public uint NOGHLFJKBGN
	{
		[Token(Token = "0x60053BB")]
		[Address(RVA = "0x1D66520", Offset = "0x1D66520", VA = "0x1D66520")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x170006AF")]
	public Transform LAINHEIINKN
	{
		[Token(Token = "0x60053BC")]
		[Address(RVA = "0x1D66578", Offset = "0x1D66578", VA = "0x1D66578")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B0")]
	public Vector3 CCIKDFGDBAM
	{
		[Token(Token = "0x60053BD")]
		[Address(RVA = "0x1D65660", Offset = "0x1D65660", VA = "0x1D65660")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x170006B1")]
	public Quaternion CCDDHEBKMGD
	{
		[Token(Token = "0x60053BE")]
		[Address(RVA = "0x1D66668", Offset = "0x1D66668", VA = "0x1D66668")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}
	}

	[Token(Token = "0x170006B2")]
	public byte KEGEAOIJFBP
	{
		[Token(Token = "0x60053BF")]
		[Address(RVA = "0x1D666F4", Offset = "0x1D666F4", VA = "0x1D666F4")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x170006B3")]
	public byte PGECJHAPKOL
	{
		[Token(Token = "0x60053C0")]
		[Address(RVA = "0x1D667C0", Offset = "0x1D667C0", VA = "0x1D667C0")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x170006B4")]
	public SceneEditPrefabConfigData NILLJMADLOD
	{
		[Token(Token = "0x60053C1")]
		[Address(RVA = "0x1D66928", Offset = "0x1D66928", VA = "0x1D66928")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B5")]
	public List<Collider> KCKIJALHFCE
	{
		[Token(Token = "0x60053C2")]
		[Address(RVA = "0x1D66980", Offset = "0x1D66980", VA = "0x1D66980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B6")]
	public List<SceneEditObjectBase> NDNNGDJCHNM
	{
		[Token(Token = "0x60053C3")]
		[Address(RVA = "0x1D669D8", Offset = "0x1D669D8", VA = "0x1D669D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B7")]
	public bool ABJNHLHELCO
	{
		[Token(Token = "0x60053C4")]
		[Address(RVA = "0x1D66A30", Offset = "0x1D66A30", VA = "0x1D66A30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006B8")]
	public int KHLBFGDBNAE
	{
		[Token(Token = "0x60053C5")]
		[Address(RVA = "0x1D66A88", Offset = "0x1D66A88", VA = "0x1D66A88")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60053C6")]
		[Address(RVA = "0x1D66AE0", Offset = "0x1D66AE0", VA = "0x1D66AE0")]
		set
		{
		}
	}

	[Token(Token = "0x170006B9")]
	public SceneEditObjectBase NBDLPKGEKNO
	{
		[Token(Token = "0x60053C8")]
		[Address(RVA = "0x1D66ECC", Offset = "0x1D66ECC", VA = "0x1D66ECC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60053C9")]
		[Address(RVA = "0x1D66F24", Offset = "0x1D66F24", VA = "0x1D66F24")]
		set
		{
		}
	}

	[Token(Token = "0x170006BA")]
	public string GIKMAINHGGK
	{
		[Token(Token = "0x60053CC")]
		[Address(RVA = "0x1D65E4C", Offset = "0x1D65E4C", VA = "0x1D65E4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60053CD")]
		[Address(RVA = "0x1D66080", Offset = "0x1D66080", VA = "0x1D66080")]
		set
		{
		}
	}

	[Token(Token = "0x60053B9")]
	[Address(RVA = "0x1D663D4", Offset = "0x1D663D4", VA = "0x1D663D4")]
	public SceneEditObjectBase()
	{
	}

	[Token(Token = "0x60053C7")]
	[Address(RVA = "0x1D66B40", Offset = "0x1D66B40", VA = "0x1D66B40")]
	public void GetAllChildren(ref List<SceneEditObjectBase> NLGILOONJCL, bool FOEBCEIDEPJ = false)
	{
	}

	[Token(Token = "0x60053CA")]
	[Address(RVA = "0x1D66F84", Offset = "0x1D66F84", VA = "0x1D66F84")]
	public bool HasParent()
	{
		return default(bool);
	}

	[Token(Token = "0x60053CB")]
	[Address(RVA = "0x1D67060", Offset = "0x1D67060", VA = "0x1D67060")]
	public bool IsOnGround()
	{
		return default(bool);
	}

	[Token(Token = "0x60053CE")]
	[Address(RVA = "0x1D67104", Offset = "0x1D67104", VA = "0x1D67104")]
	public void InitPrefabData(int HHLONFLCJBL, SceneEditPrefabConfigData AJKBOONEOAB, Vector3 CNFLCNGJEMH, byte HLANJEBOAHP, byte IGFCMKGBAHF = 0)
	{
	}

	[Token(Token = "0x60053CF")]
	[Address(RVA = "0x1D67E3C", Offset = "0x1D67E3C", VA = "0x1D67E3C", Slot = "4")]
	protected virtual void GNNLEHGCDHP()
	{
	}

	[Token(Token = "0x60053D0")]
	[Address(RVA = "0x1D67650", Offset = "0x1D67650", VA = "0x1D67650")]
	public void UseDirection(byte COCOBLKAIMJ)
	{
	}

	[Token(Token = "0x60053D1")]
	[Address(RVA = "0x1D67400", Offset = "0x1D67400", VA = "0x1D67400")]
	public void UseFreeDirection(byte IHGPNOADMDL)
	{
	}

	[Token(Token = "0x60053D2")]
	[Address(RVA = "0x1D67E90", Offset = "0x1D67E90", VA = "0x1D67E90")]
	public void ReInitMeshRenderers()
	{
	}

	[Token(Token = "0x60053D3")]
	[Address(RVA = "0x1D677F0", Offset = "0x1D677F0", VA = "0x1D677F0")]
	private void MOHGPKDEBIM()
	{
	}

	[Token(Token = "0x60053D4")]
	[Address(RVA = "0x1D68198", Offset = "0x1D68198", VA = "0x1D68198")]
	private void LLIPGNOGKPP()
	{
	}

	[Token(Token = "0x60053D5")]
	[Address(RVA = "0x1D683A0", Offset = "0x1D683A0", VA = "0x1D683A0")]
	private void AIAPEOOPOPN()
	{
	}

	[Token(Token = "0x60053D6")]
	[Address(RVA = "0x1D69208", Offset = "0x1D69208", VA = "0x1D69208")]
	private void KCCKIEFLGBM()
	{
	}

	[Token(Token = "0x60053D7")]
	[Address(RVA = "0x1D69558", Offset = "0x1D69558", VA = "0x1D69558")]
	private Bounds IKDMIIGOHMD()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Bounds);
	}

	[Token(Token = "0x60053D8")]
	[Address(RVA = "0x1D698D4", Offset = "0x1D698D4", VA = "0x1D698D4")]
	public void OnReadyGroupSelected(bool KIMIMHOGBBE)
	{
	}

	[Token(Token = "0x60053D9")]
	[Address(RVA = "0x1D69C64", Offset = "0x1D69C64", VA = "0x1D69C64")]
	public void OnSelected(bool KIMIMHOGBBE)
	{
	}

	[Token(Token = "0x60053DA")]
	[Address(RVA = "0x1D66E04", Offset = "0x1D66E04", VA = "0x1D66E04")]
	public bool HasAnyChild()
	{
		return default(bool);
	}

	[Token(Token = "0x60053DB")]
	[Address(RVA = "0x1D6A0A8", Offset = "0x1D6A0A8", VA = "0x1D6A0A8")]
	public bool HasChild(SceneEditObjectBase ECINOMEHBKA)
	{
		return default(bool);
	}

	[Token(Token = "0x60053DC")]
	[Address(RVA = "0x1D6A170", Offset = "0x1D6A170", VA = "0x1D6A170")]
	public void AddChild(SceneEditObjectBase ECINOMEHBKA)
	{
	}

	[Token(Token = "0x60053DD")]
	[Address(RVA = "0x1D6A290", Offset = "0x1D6A290", VA = "0x1D6A290")]
	public void RemoveChild(SceneEditObjectBase ECINOMEHBKA)
	{
	}

	[Token(Token = "0x60053DE")]
	[Address(RVA = "0x1D6A370", Offset = "0x1D6A370", VA = "0x1D6A370")]
	public void GetChildrenInfo(ref List<SceneEditCrosshair.NKAPFDDIAFI> NLGILOONJCL, SceneEditObjectBase KJOPKNNLPGP, bool PKJAAOKNDEL)
	{
	}

	[Token(Token = "0x60053DF")]
	[Address(RVA = "0x1D6A9F0", Offset = "0x1D6A9F0", VA = "0x1D6A9F0")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x60053E0")]
	[Address(RVA = "0x1D6AB90", Offset = "0x1D6AB90", VA = "0x1D6AB90", Slot = "5")]
	public virtual void OnRemove(bool MMOHANJKPBG)
	{
	}

	[Token(Token = "0x60053E1")]
	[Address(RVA = "0x1D6ABEC", Offset = "0x1D6ABEC", VA = "0x1D6ABEC", Slot = "6")]
	public virtual NANKDCKDDIG GetExtraInfo()
	{
		return null;
	}

	[Token(Token = "0x60053E2")]
	[Address(RVA = "0x1D6AC44", Offset = "0x1D6AC44", VA = "0x1D6AC44", Slot = "7")]
	public virtual void ApplyExtraInfo(NANKDCKDDIG PKAHCEKFHIA, bool MMOHANJKPBG = false)
	{
	}

	[Token(Token = "0x60053E3")]
	[Address(RVA = "0x1D6ACB4", Offset = "0x1D6ACB4", VA = "0x1D6ACB4", Slot = "8")]
	public virtual void RemoveIfAllowed(Action HLLGOKLLGEH)
	{
	}

	[Token(Token = "0x60053E4")]
	[Address(RVA = "0x1D6AD30", Offset = "0x1D6AD30", VA = "0x1D6AD30", Slot = "9")]
	protected virtual void DAFAAIIPJPB()
	{
	}

	[Token(Token = "0x60053E5")]
	[Address(RVA = "0x1D6AD84", Offset = "0x1D6AD84", VA = "0x1D6AD84")]
	public List<ItemEditAttributeUIData> UseObjectAttributeGenUIData(ItemEditAttributeBaseConfig FJMPFNBIFOB)
	{
		return null;
	}
}
