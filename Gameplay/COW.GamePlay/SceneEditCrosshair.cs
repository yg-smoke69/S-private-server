using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000ABC")]
public class SceneEditCrosshair : MonoBehaviour
{
	[Token(Token = "0x2000ABD")]
	public class NKAPFDDIAFI
	{
		[Token(Token = "0x4005DD6")]
		[FieldOffset(Offset = "0x8")]
		public SceneEditCrosshair CNNNEJIMIIF;

		[Token(Token = "0x4005DD7")]
		[FieldOffset(Offset = "0xC")]
		public SceneEditPrefabConfigData NILLJMADLOD;

		[Token(Token = "0x4005DD8")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 CNMJNMDBNED;

		[Token(Token = "0x4005DD9")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 FPIHNPCPBEM;

		[Token(Token = "0x4005DDA")]
		[FieldOffset(Offset = "0x28")]
		public int ACKPAFJEBMH;

		[Token(Token = "0x4005DDB")]
		[FieldOffset(Offset = "0x2C")]
		public int LILDCILPMNI;

		[Token(Token = "0x4005DDC")]
		[FieldOffset(Offset = "0x30")]
		public List<ItemEditAttributeCacheValueBase> ILMPOFGBGLC;

		[Token(Token = "0x4005DDD")]
		[FieldOffset(Offset = "0x34")]
		public IOBOKBBLLBI EELNBDPPCHE;

		[Token(Token = "0x6005267")]
		[Address(RVA = "0x29CCF2C", Offset = "0x29CCF2C", VA = "0x29CCF2C")]
		public NKAPFDDIAFI()
		{
		}
	}

	[Token(Token = "0x4005DB6")]
	[FieldOffset(Offset = "0xC")]
	public float BoundExpands;

	[Token(Token = "0x4005DB7")]
	[FieldOffset(Offset = "0x10")]
	private List<NKAPFDDIAFI> ONDLPOFEKLF;

	[Token(Token = "0x4005DB8")]
	[FieldOffset(Offset = "0x14")]
	protected List<Collider> HLHIBCMJGCJ;

	[Token(Token = "0x4005DB9")]
	[FieldOffset(Offset = "0x18")]
	private SceneEditPrefabConfigData OHFBJJBNGLC;

	[Token(Token = "0x4005DBA")]
	[FieldOffset(Offset = "0x1C")]
	private SceneEditAgent GOBNFJBKPLN;

	[Token(Token = "0x4005DBB")]
	[FieldOffset(Offset = "0x20")]
	private JPPGAJBAAKK NPNLKCNJMFK;

	[Token(Token = "0x4005DBC")]
	[FieldOffset(Offset = "0x24")]
	private Transform EEOCPFHNDEN;

	[Token(Token = "0x4005DBD")]
	[FieldOffset(Offset = "0x28")]
	public int m_GroupIndex;

	[Token(Token = "0x4005DBE")]
	[FieldOffset(Offset = "0x2C")]
	public bool m_IsInReadyGroup;

	[Token(Token = "0x4005DBF")]
	[FieldOffset(Offset = "0x2D")]
	public bool m_IsInGroup;

	[Token(Token = "0x4005DC0")]
	[FieldOffset(Offset = "0x2E")]
	public bool m_IsCrossHairSelected;

	[Token(Token = "0x4005DC1")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 m_CameraFowardDir;

	[Token(Token = "0x4005DC2")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 m_PosToSelectedObj;

	[Token(Token = "0x4005DC3")]
	[FieldOffset(Offset = "0x48")]
	private SceneEditCrosshair FEEPNONOAMA;

	[Token(Token = "0x4005DC4")]
	[FieldOffset(Offset = "0x4C")]
	private bool OPIIPGLIFNG;

	[Token(Token = "0x4005DC5")]
	[FieldOffset(Offset = "0x50")]
	private List<int> GFACKDPKPEB;

	[Token(Token = "0x4005DC6")]
	[FieldOffset(Offset = "0x54")]
	private float JNOIJEDOBIN;

	[Token(Token = "0x4005DC7")]
	[FieldOffset(Offset = "0x58")]
	private float PHNBBACFGKH;

	[Token(Token = "0x4005DC8")]
	[FieldOffset(Offset = "0x5C")]
	protected Material AKKDOGIGLNE;

	[Token(Token = "0x4005DC9")]
	[FieldOffset(Offset = "0x60")]
	protected Material CKFKPCFJAOD;

	[Token(Token = "0x4005DCA")]
	[FieldOffset(Offset = "0x64")]
	public List<ItemEditAttributeCacheValueBase> ItemEditAttributeCacheValue;

	[Token(Token = "0x4005DCB")]
	[FieldOffset(Offset = "0x68")]
	public bool IsCurSelectRootCrosshair;

	[Token(Token = "0x4005DCC")]
	[FieldOffset(Offset = "0x6C")]
	public IOBOKBBLLBI ObjectColor;

	[Token(Token = "0x4005DCD")]
	[FieldOffset(Offset = "0x70")]
	private MusicElement BHEIBODDLFL;

	[Token(Token = "0x4005DCE")]
	[FieldOffset(Offset = "0x74")]
	private Vector3[] LAPEMKAKFGP;

	[Token(Token = "0x4005DCF")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 FJLPLHPGIDA;

	[Token(Token = "0x4005DD0")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 IPJFIMNNHIG;

	[Token(Token = "0x4005DD1")]
	[FieldOffset(Offset = "0x90")]
	private Vector3 BELFPFMDIPE;

	[Token(Token = "0x4005DD2")]
	[FieldOffset(Offset = "0x9C")]
	public int m_TempIndex;

	[Token(Token = "0x4005DD3")]
	[FieldOffset(Offset = "0xA0")]
	private bool AMBNDHECKFG;

	[Token(Token = "0x4005DD4")]
	[FieldOffset(Offset = "0xA4")]
	private uint IOIDNBIBJKI;

	[Token(Token = "0x4005DD5")]
	[FieldOffset(Offset = "0xA8")]
	private List<int> CHJGDMAGNBP;

	[Token(Token = "0x1700065C")]
	public List<NKAPFDDIAFI> GGFAEHBHFFD
	{
		[Token(Token = "0x600523F")]
		[Address(RVA = "0x29B8ACC", Offset = "0x29B8ACC", VA = "0x29B8ACC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700065D")]
	public List<Collider> HOEBBBPPIKB
	{
		[Token(Token = "0x6005240")]
		[Address(RVA = "0x29C9ED0", Offset = "0x29C9ED0", VA = "0x29C9ED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700065E")]
	public SceneEditPrefabConfigData NILLJMADLOD
	{
		[Token(Token = "0x6005241")]
		[Address(RVA = "0x29BD910", Offset = "0x29BD910", VA = "0x29BD910")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700065F")]
	public Transform LAINHEIINKN
	{
		[Token(Token = "0x6005242")]
		[Address(RVA = "0x29BB258", Offset = "0x29BB258", VA = "0x29BB258")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000660")]
	public bool GCBKJAOELPC
	{
		[Token(Token = "0x6005243")]
		[Address(RVA = "0x29B9394", Offset = "0x29B9394", VA = "0x29B9394")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000661")]
	public List<int> GAMLPFNKPLF
	{
		[Token(Token = "0x6005244")]
		[Address(RVA = "0x29BF8D0", Offset = "0x29BF8D0", VA = "0x29BF8D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000662")]
	public Vector3 HELAEKCACBM
	{
		[Token(Token = "0x6005245")]
		[Address(RVA = "0x29C9F28", Offset = "0x29C9F28", VA = "0x29C9F28")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000663")]
	public Vector3 KLKNFDNALCK
	{
		[Token(Token = "0x6005246")]
		[Address(RVA = "0x29C9F98", Offset = "0x29C9F98", VA = "0x29C9F98")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Token(Token = "0x6005247")]
		[Address(RVA = "0x29BB148", Offset = "0x29BB148", VA = "0x29BB148")]
		set
		{
		}
	}

	[Token(Token = "0x17000664")]
	public Vector3 PAFLLDNOMHE
	{
		[Token(Token = "0x6005248")]
		[Address(RVA = "0x29CA008", Offset = "0x29CA008", VA = "0x29CA008")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Token(Token = "0x6005249")]
		[Address(RVA = "0x29BB1D0", Offset = "0x29BB1D0", VA = "0x29BB1D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000665")]
	public uint KEGEAOIJFBP
	{
		[Token(Token = "0x6005250")]
		[Address(RVA = "0x29CB750", Offset = "0x29CB750", VA = "0x29CB750")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000666")]
	public uint PGECJHAPKOL
	{
		[Token(Token = "0x6005251")]
		[Address(RVA = "0x29CB808", Offset = "0x29CB808", VA = "0x29CB808")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x600523E")]
	[Address(RVA = "0x29C9D68", Offset = "0x29C9D68", VA = "0x29C9D68")]
	public SceneEditCrosshair()
	{
	}

	[Token(Token = "0x600524A")]
	[Address(RVA = "0x29CA078", Offset = "0x29CA078", VA = "0x29CA078")]
	protected List<Renderer> NFHEMHLPFNB(Transform LHGLOHKNEPC)
	{
		return null;
	}

	[Token(Token = "0x600524B")]
	[Address(RVA = "0x29CA328", Offset = "0x29CA328", VA = "0x29CA328", Slot = "4")]
	public virtual void Init(SceneEditAgent CCJEIDKEBJL, SceneEditPrefabConfigData JHENJMANOEL)
	{
	}

	[Token(Token = "0x600524C")]
	[Address(RVA = "0x29CB4D8", Offset = "0x29CB4D8", VA = "0x29CB4D8")]
	public bool CanShadingColor()
	{
		return default(bool);
	}

	[Token(Token = "0x600524D")]
	[Address(RVA = "0x29CB54C", Offset = "0x29CB54C", VA = "0x29CB54C")]
	public void OnCrosshairAppear()
	{
	}

	[Token(Token = "0x600524E")]
	[Address(RVA = "0x29BF928", Offset = "0x29BF928", VA = "0x29BF928")]
	public bool HasPrefabData()
	{
		return default(bool);
	}

	[Token(Token = "0x600524F")]
	[Address(RVA = "0x29BE214", Offset = "0x29BE214", VA = "0x29BE214")]
	public bool CanPutDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6005252")]
	[Address(RVA = "0x29BFC68", Offset = "0x29BFC68", VA = "0x29BFC68")]
	public void OnRotate()
	{
	}

	[Token(Token = "0x6005253")]
	[Address(RVA = "0x29C2984", Offset = "0x29C2984", VA = "0x29C2984")]
	public void RecordChildPos()
	{
	}

	[Token(Token = "0x6005254")]
	[Address(RVA = "0x29CB95C", Offset = "0x29CB95C", VA = "0x29CB95C")]
	public void OnCrosshairScale(Vector3 IOOPPDAAMEP)
	{
	}

	[Token(Token = "0x6005255")]
	[Address(RVA = "0x29CBE44", Offset = "0x29CBE44", VA = "0x29CBE44")]
	public void BeforeRecycle()
	{
	}

	[Token(Token = "0x6005256")]
	[Address(RVA = "0x29CBFB4", Offset = "0x29CBFB4", VA = "0x29CBFB4")]
	public void ClearChildren()
	{
	}

	[Token(Token = "0x6005257")]
	[Address(RVA = "0x29C11E0", Offset = "0x29C11E0", VA = "0x29C11E0")]
	public void SetChildrenInfo(List<NKAPFDDIAFI> JDDBACJFKFE, bool FANNKIKGFNF, int LLFOENCFLDO, bool PKJAAOKNDEL)
	{
	}

	[Token(Token = "0x6005258")]
	[Address(RVA = "0x29B93EC", Offset = "0x29B93EC", VA = "0x29B93EC")]
	public SceneEditObjectBase DoPutdown(bool KJLCOKFODCM, EJHLCKLOFKD OIDANMGABJH, int BCDNFHNJGIE, [Optional] SceneEditObjectBase PHLFBBIAEFE)
	{
		return null;
	}

	[Token(Token = "0x6005259")]
	[Address(RVA = "0x29B6488", Offset = "0x29B6488", VA = "0x29B6488")]
	public void UpdatePosition(ref List<int> FBHHENGBOCJ, ref List<int> HNPINLKADPG)
	{
	}

	[Token(Token = "0x600525A")]
	[Address(RVA = "0x29CCAAC", Offset = "0x29CCAAC", VA = "0x29CCAAC")]
	public void UpdatePostionByGroup(SceneEditCrosshair KIMIMHOGBBE)
	{
	}

	[Token(Token = "0x600525B")]
	[Address(RVA = "0x29CCC6C", Offset = "0x29CCC6C", VA = "0x29CCC6C", Slot = "5")]
	protected virtual bool PNONNFCEBAF()
	{
		return default(bool);
	}

	[Token(Token = "0x600525C")]
	[Address(RVA = "0x29CC1FC", Offset = "0x29CC1FC", VA = "0x29CC1FC")]
	private Vector3 HKJKELOAONE(Ray IAHMBEEGMCH, RaycastHit OFNFHFAFGDE)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600525D")]
	[Address(RVA = "0x29CB240", Offset = "0x29CB240", VA = "0x29CB240")]
	private void DLHDHFGHGGH()
	{
	}

	[Token(Token = "0x600525E")]
	[Address(RVA = "0x29BBA94", Offset = "0x29BBA94", VA = "0x29BBA94")]
	public float GetHeight()
	{
		return default(float);
	}

	[Token(Token = "0x600525F")]
	[Address(RVA = "0x29C551C", Offset = "0x29C551C", VA = "0x29C551C")]
	public void UpdateRayCastDis(DNLNDBDCGHM HPKCDJLHEFO)
	{
	}

	[Token(Token = "0x6005260")]
	[Address(RVA = "0x29CCCC4", Offset = "0x29CCCC4", VA = "0x29CCCC4", Slot = "6")]
	public virtual void InheritDataFromCrosshairToSceneEditObject(SceneEditObjectBase ECINOMEHBKA)
	{
	}

	[Token(Token = "0x6005261")]
	[Address(RVA = "0x29C1D7C", Offset = "0x29C1D7C", VA = "0x29C1D7C")]
	public void SetGroupParams(SceneEditCrosshair EBHMIFAADIJ, Vector3 CKCKDDKENAN)
	{
	}

	[Token(Token = "0x6005262")]
	[Address(RVA = "0x29C0134", Offset = "0x29C0134", VA = "0x29C0134")]
	public void ResetPosAndDir()
	{
	}

	[Token(Token = "0x6005263")]
	[Address(RVA = "0x29CCD20", Offset = "0x29CCD20", VA = "0x29CCD20")]
	private Vector3 IAKFGLDNICM(Vector3 MLCIHBOHEHE, Vector3 BBNODIIBDDC, Vector3 OFOBFAPGDLN, float EGHHKPCJNCH)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6005264")]
	[Address(RVA = "0x29BFEA4", Offset = "0x29BFEA4", VA = "0x29BFEA4")]
	public void OnGroupRotatePos()
	{
	}

	[Token(Token = "0x6005265")]
	[Address(RVA = "0x29B82D8", Offset = "0x29B82D8", VA = "0x29B82D8")]
	public void ChangeStatus(bool FGECPMHFFFE)
	{
	}

	[Token(Token = "0x6005266")]
	[Address(RVA = "0x29C6994", Offset = "0x29C6994", VA = "0x29C6994")]
	public void RefreshState()
	{
	}
}
