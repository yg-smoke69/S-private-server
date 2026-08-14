using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000AB7")]
public class SceneEditAgent : MonoBehaviour, _Attribute
{
	[Token(Token = "0x2000AB8")]
	private enum FHDDNFIDNLP
	{
		[Token(Token = "0x4005DAB")]
		EPerspectiveToOrthographic,
		[Token(Token = "0x4005DAC")]
		EHorizontalMove,
		[Token(Token = "0x4005DAD")]
		EOrthographicRotation
	}

	[Token(Token = "0x2000AB9")]
	public enum OJLNGFLPIEA
	{
		[Token(Token = "0x4005DAF")]
		Up,
		[Token(Token = "0x4005DB0")]
		Down,
		[Token(Token = "0x4005DB1")]
		Left,
		[Token(Token = "0x4005DB2")]
		Right
	}

	[Token(Token = "0x2000ABA")]
	private sealed class BFPLOIIJHHN
	{
		[Token(Token = "0x4005DB3")]
		[FieldOffset(Offset = "0x8")]
		internal SceneEditObjectBase JFCOKLDMDKH;

		[Token(Token = "0x600523A")]
		[Address(RVA = "0x29C3C74", Offset = "0x29C3C74", VA = "0x29C3C74")]
		public BFPLOIIJHHN()
		{
		}

		[Token(Token = "0x600523B")]
		[Address(RVA = "0x29C9408", Offset = "0x29C9408", VA = "0x29C9408")]
		internal bool CHOPCLCOBKC(SceneEditObjectBase AJKBOONEOAB)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000ABB")]
	private sealed class PIFNEBFCDMI
	{
		[Token(Token = "0x4005DB4")]
		[FieldOffset(Offset = "0x8")]
		internal SceneEditObjectBase ECINOMEHBKA;

		[Token(Token = "0x4005DB5")]
		[FieldOffset(Offset = "0xC")]
		internal SceneEditAgent GADHAMJEKIM;

		[Token(Token = "0x600523C")]
		[Address(RVA = "0x29C5EB4", Offset = "0x29C5EB4", VA = "0x29C5EB4")]
		public PIFNEBFCDMI()
		{
		}

		[Token(Token = "0x600523D")]
		[Address(RVA = "0x29C9498", Offset = "0x29C9498", VA = "0x29C9498")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x4005D6F")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 WorldCenter;

	[Token(Token = "0x4005D70")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 CameraOriginalPos;

	[Token(Token = "0x4005D71")]
	[FieldOffset(Offset = "0x24")]
	private Transform EEOCPFHNDEN;

	[Token(Token = "0x4005D72")]
	[FieldOffset(Offset = "0x28")]
	private List<SceneEditCrosshair> JFBHGMNOENE;

	[Token(Token = "0x4005D73")]
	[FieldOffset(Offset = "0x2C")]
	public SceneEditCrosshair mLastCrosshairObj;

	[Token(Token = "0x4005D74")]
	[FieldOffset(Offset = "0x30")]
	private HCNFMGAKJPM HGDLBCOGNCJ;

	[Token(Token = "0x4005D75")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<UGCLevelCustomPath, List<SceneEditCrosshair>> HLCOHAGNONE;

	[Token(Token = "0x4005D76")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<uint, ItemEditAttributeBaseConfig> ACJNPHLJINJ;

	[Token(Token = "0x4005D77")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<uint, List<ItemEditAttributeUIData>> FIFHAIIBPFH;

	[Token(Token = "0x4005D78")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<uint, ItemFunctionAttributeBaseConfig> LGBBIKBJHIF;

	[Token(Token = "0x4005D79")]
	[FieldOffset(Offset = "0x44")]
	private bool _003CFENHKBMDAJD_003Ek__BackingField;

	[Token(Token = "0x4005D7A")]
	[FieldOffset(Offset = "0x45")]
	private bool GIFEKPPKFMO;

	[Token(Token = "0x4005D7B")]
	[FieldOffset(Offset = "0x48")]
	private EJHLCKLOFKD AJCPDAMDEHC;

	[Token(Token = "0x4005D7C")]
	[FieldOffset(Offset = "0x4C")]
	private OHOCICDJKBM OIPBPLNIKEG;

	[Token(Token = "0x4005D7D")]
	[FieldOffset(Offset = "0x50")]
	private SceneEditGridMesh LOJFLFHJBPF;

	[Token(Token = "0x4005D7E")]
	[FieldOffset(Offset = "0x54")]
	private bool DMHKIHAJMOP;

	[Token(Token = "0x4005D7F")]
	[FieldOffset(Offset = "0x58")]
	private KMPCDKFOBPF KKCCGANKAAB;

	[Token(Token = "0x4005D80")]
	[FieldOffset(Offset = "0x5C")]
	private GameObject FHHJLKPFNEC;

	[Token(Token = "0x4005D81")]
	[FieldOffset(Offset = "0x60")]
	private bool _003CGIDDOMDGBHH_003Ek__BackingField;

	[Token(Token = "0x4005D82")]
	[FieldOffset(Offset = "0x61")]
	private bool NHFNEDGOKJE;

	[Token(Token = "0x4005D83")]
	[FieldOffset(Offset = "0x64")]
	private DNLNDBDCGHM DENMBLECKDC;

	[Token(Token = "0x4005D84")]
	[FieldOffset(Offset = "0x68")]
	private NKDDKDPPCGG COGLOPFDLMA;

	[Token(Token = "0x4005D85")]
	[FieldOffset(Offset = "0x6C")]
	private Camera EDKAEDJLAHE;

	[Token(Token = "0x4005D86")]
	[FieldOffset(Offset = "0x70")]
	private float HMNLMDIBJHA;

	[Token(Token = "0x4005D87")]
	[FieldOffset(Offset = "0x74")]
	private float JDBNLNBCDMG;

	[Token(Token = "0x4005D88")]
	[FieldOffset(Offset = "0x78")]
	private float JNIBEJBMHIO;

	[Token(Token = "0x4005D89")]
	[FieldOffset(Offset = "0x7C")]
	private Player FLMNAEMHEEE;

	[Token(Token = "0x4005D8A")]
	[FieldOffset(Offset = "0x80")]
	private JPPGAJBAAKK JHMIKLDNKGF;

	[Token(Token = "0x4005D8B")]
	[FieldOffset(Offset = "0x84")]
	private GameObject FBLPDPKDGIK;

	[Token(Token = "0x4005D8C")]
	[FieldOffset(Offset = "0x88")]
	private SceneEditFloorPlane JMNFPNLFPPI;

	[Token(Token = "0x4005D8D")]
	[FieldOffset(Offset = "0x8C")]
	private float IHGHGGJMAGF;

	[Token(Token = "0x4005D8E")]
	[FieldOffset(Offset = "0x90")]
	private float DPKKMPOOLFH;

	[Token(Token = "0x4005D8F")]
	[FieldOffset(Offset = "0x94")]
	private bool ECJPNBBJPJG;

	[Token(Token = "0x4005D90")]
	[FieldOffset(Offset = "0x98")]
	private float PJIDMFOOHDD;

	[Token(Token = "0x4005D91")]
	[FieldOffset(Offset = "0x9C")]
	private bool _003COIFBEOKINJI_003Ek__BackingField;

	[Token(Token = "0x4005D92")]
	[FieldOffset(Offset = "0xA0")]
	private Dictionary<UGCLevelCustomPath, UGCLevelCustomPath> BKHEIIELJNO;

	[Token(Token = "0x4005D93")]
	[FieldOffset(Offset = "0xA4")]
	private SceneEditObjectBase KCFONJLIAHL;

	[Token(Token = "0x4005D94")]
	[FieldOffset(Offset = "0xA8")]
	private List<int> JNIPLOPDEOG;

	[Token(Token = "0x4005D95")]
	[FieldOffset(Offset = "0xAC")]
	private List<int> GPCHHCPCPDA;

	[Token(Token = "0x4005D96")]
	[FieldOffset(Offset = "0xB0")]
	private List<int> KLBGPCMBIIM;

	[Token(Token = "0x4005D97")]
	[FieldOffset(Offset = "0xB4")]
	private List<int> JAPACELGAIO;

	[Token(Token = "0x4005D98")]
	[FieldOffset(Offset = "0xB8")]
	private float KEJKHDMJNJJ;

	[Token(Token = "0x4005D99")]
	[FieldOffset(Offset = "0xBC")]
	private List<int> CIOFEJHDNNH;

	[Token(Token = "0x4005D9A")]
	[FieldOffset(Offset = "0xC0")]
	private UserControlHandler KKOINGCFLED;

	[Token(Token = "0x4005D9B")]
	[FieldOffset(Offset = "0xC4")]
	public bool IsEditMode;

	[Token(Token = "0x4005D9C")]
	[FieldOffset(Offset = "0xC5")]
	public bool IsPhotographMode;

	[Token(Token = "0x4005D9D")]
	private const float KINDGEAMENC = 326f;

	[Token(Token = "0x4005D9E")]
	private const float KALEDIELNCI = 300f;

	[Token(Token = "0x4005D9F")]
	private const float PLIAMDPHPHE = 3f;

	[Token(Token = "0x4005DA0")]
	[FieldOffset(Offset = "0xC8")]
	private Vector3 HGIGNPNJLBO;

	[Token(Token = "0x4005DA1")]
	[FieldOffset(Offset = "0xD4")]
	private Vector3 MJLCHMMJKKH;

	[Token(Token = "0x4005DA2")]
	[FieldOffset(Offset = "0xE0")]
	private Quaternion AMPECGBOFPG;

	[Token(Token = "0x4005DA3")]
	[FieldOffset(Offset = "0xF0")]
	private Quaternion BAMIIHMLHLB;

	[Token(Token = "0x4005DA4")]
	[FieldOffset(Offset = "0x100")]
	private Vector3 APLINDONKGJ;

	[Token(Token = "0x4005DA5")]
	[FieldOffset(Offset = "0x10C")]
	private float FPGGDNNFGDM;

	[Token(Token = "0x4005DA6")]
	[FieldOffset(Offset = "0x110")]
	private bool DGGJEGEAFBD;

	[Token(Token = "0x4005DA7")]
	[FieldOffset(Offset = "0x114")]
	private float CJNELCLEFAK;

	[Token(Token = "0x4005DA8")]
	[FieldOffset(Offset = "0x118")]
	private Vector3 BIPMIHFLKMF;

	[Token(Token = "0x4005DA9")]
	[FieldOffset(Offset = "0x124")]
	private FHDDNFIDNLP JPKIJHIAGCN;

	[Token(Token = "0x1700064D")]
	public Transform LAINHEIINKN
	{
		[Token(Token = "0x60051D3")]
		[Address(RVA = "0x29B1A8C", Offset = "0x29B1A8C", VA = "0x29B1A8C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700064E")]
	private SceneEditCrosshair EFHPJGPNIDN
	{
		[Token(Token = "0x60051D4")]
		[Address(RVA = "0x29B1B7C", Offset = "0x29B1B7C", VA = "0x29B1B7C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60051D5")]
		[Address(RVA = "0x29B1C74", Offset = "0x29B1C74", VA = "0x29B1C74")]
		set
		{
		}
	}

	[Token(Token = "0x1700064F")]
	public SceneEditCrosshair NNLEGGFDKLG
	{
		[Token(Token = "0x60051D6")]
		[Address(RVA = "0x29B1D80", Offset = "0x29B1D80", VA = "0x29B1D80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000650")]
	public HCNFMGAKJPM OCOBLLCKBKM
	{
		[Token(Token = "0x60051D7")]
		[Address(RVA = "0x29B1DE0", Offset = "0x29B1DE0", VA = "0x29B1DE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000651")]
	public bool OAOLKAKGFAB
	{
		[Token(Token = "0x60051D8")]
		[Address(RVA = "0x29B1E38", Offset = "0x29B1E38", VA = "0x29B1E38")]
		private get
		{
			return default(bool);
		}
		[Token(Token = "0x60051D9")]
		[Address(RVA = "0x29B1E40", Offset = "0x29B1E40", VA = "0x29B1E40")]
		set
		{
		}
	}

	[Token(Token = "0x17000652")]
	public bool BGDLHIJKHPF
	{
		[Token(Token = "0x60051DA")]
		[Address(RVA = "0x29B1E48", Offset = "0x29B1E48", VA = "0x29B1E48")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000653")]
	public EJHLCKLOFKD FBAHGJDGGAP
	{
		[Token(Token = "0x60051DB")]
		[Address(RVA = "0x29B1EA0", Offset = "0x29B1EA0", VA = "0x29B1EA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60051DC")]
		[Address(RVA = "0x29B1EF8", Offset = "0x29B1EF8", VA = "0x29B1EF8")]
		set
		{
		}
	}

	[Token(Token = "0x17000654")]
	public OHOCICDJKBM GKAHBJDIOFM
	{
		[Token(Token = "0x60051DD")]
		[Address(RVA = "0x29B1F58", Offset = "0x29B1F58", VA = "0x29B1F58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000655")]
	public SceneEditGridMesh EBPPOJDNMIL
	{
		[Token(Token = "0x60051DE")]
		[Address(RVA = "0x29B1FB0", Offset = "0x29B1FB0", VA = "0x29B1FB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000656")]
	public bool IIGGBPEJLFM
	{
		[Token(Token = "0x60051DF")]
		[Address(RVA = "0x29B2008", Offset = "0x29B2008", VA = "0x29B2008")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000657")]
	public KMPCDKFOBPF GBCGGCEIHFK
	{
		[Token(Token = "0x60051E0")]
		[Address(RVA = "0x29B2060", Offset = "0x29B2060", VA = "0x29B2060")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000658")]
	public bool OMIHCMKJAJB
	{
		[Token(Token = "0x60051E2")]
		[Address(RVA = "0x29B20C0", Offset = "0x29B20C0", VA = "0x29B20C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60051E1")]
		[Address(RVA = "0x29B20B8", Offset = "0x29B20B8", VA = "0x29B20B8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000659")]
	public bool GGNOMELLBIL
	{
		[Token(Token = "0x60051E3")]
		[Address(RVA = "0x29B20C8", Offset = "0x29B20C8", VA = "0x29B20C8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60051E4")]
		[Address(RVA = "0x29B2140", Offset = "0x29B2140", VA = "0x29B2140")]
		set
		{
		}
	}

	[Token(Token = "0x1700065A")]
	public bool NGEFDMAMIPF
	{
		[Token(Token = "0x60051E6")]
		[Address(RVA = "0x29B21A8", Offset = "0x29B21A8", VA = "0x29B21A8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60051E5")]
		[Address(RVA = "0x29B21A0", Offset = "0x29B21A0", VA = "0x29B21A0")]
		private set
		{
		}
	}

	[Token(Token = "0x1700065B")]
	public SceneEditObjectBase HPHKNPEBMDF
	{
		[Token(Token = "0x60051EC")]
		[Address(RVA = "0x29B3364", Offset = "0x29B3364", VA = "0x29B3364")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60051D2")]
	[Address(RVA = "0x29B185C", Offset = "0x29B185C", VA = "0x29B185C")]
	public SceneEditAgent()
	{
	}

	[Token(Token = "0x60051E7")]
	[Address(RVA = "0x29B21B0", Offset = "0x29B21B0", VA = "0x29B21B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60051E8")]
	[Address(RVA = "0x29B29CC", Offset = "0x29B29CC", VA = "0x29B29CC")]
	private void CLOLFONPLPE(uint AKBEGLMGDCM)
	{
	}

	[Token(Token = "0x60051E9")]
	[Address(RVA = "0x29B2DAC", Offset = "0x29B2DAC", VA = "0x29B2DAC")]
	private void NKMLIDDLMMK(float LCMKCHOILIB)
	{
	}

	[Token(Token = "0x60051EA")]
	[Address(RVA = "0x29B31C8", Offset = "0x29B31C8", VA = "0x29B31C8")]
	public static uint GetFloorPlaneLayerMask()
	{
		return default(uint);
	}

	[Token(Token = "0x60051EB")]
	[Address(RVA = "0x29B3298", Offset = "0x29B3298", VA = "0x29B3298")]
	public void BindTrackingPlayer()
	{
	}

	[Token(Token = "0x60051ED")]
	[Address(RVA = "0x29B33BC", Offset = "0x29B33BC", VA = "0x29B33BC")]
	private void Update()
	{
	}

	[Token(Token = "0x60051EE")]
	[Address(RVA = "0x29B6350", Offset = "0x29B6350", VA = "0x29B6350")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60051EF")]
	[Address(RVA = "0x29B4348", Offset = "0x29B4348", VA = "0x29B4348")]
	private void KAJBKPKJNEG()
	{
	}

	[Token(Token = "0x60051F0")]
	[Address(RVA = "0x29B8B24", Offset = "0x29B8B24", VA = "0x29B8B24")]
	public bool IsCurrentSelectedInReadyGroup()
	{
		return default(bool);
	}

	[Token(Token = "0x60051F1")]
	[Address(RVA = "0x29B8C20", Offset = "0x29B8C20", VA = "0x29B8C20")]
	public bool CheckSelectedIsInGroup()
	{
		return default(bool);
	}

	[Token(Token = "0x60051F2")]
	[Address(RVA = "0x29B8D1C", Offset = "0x29B8D1C", VA = "0x29B8D1C")]
	public bool AddModifyObjInReadyGroupList()
	{
		return default(bool);
	}

	[Token(Token = "0x60051F3")]
	[Address(RVA = "0x29B8E38", Offset = "0x29B8E38", VA = "0x29B8E38")]
	public bool RemoveModifyObjInReadyGroupList()
	{
		return default(bool);
	}

	[Token(Token = "0x60051F4")]
	[Address(RVA = "0x29B8EB8", Offset = "0x29B8EB8", VA = "0x29B8EB8")]
	public void OnResMgrUnSelected()
	{
	}

	[Token(Token = "0x60051F5")]
	[Address(RVA = "0x29BA90C", Offset = "0x29BA90C", VA = "0x29BA90C")]
	public void OnResMgrSelected(SceneEditObjectBase FFDHFKIMFDG)
	{
	}

	[Token(Token = "0x60051F6")]
	[Address(RVA = "0x29BB794", Offset = "0x29BB794", VA = "0x29BB794")]
	public void UpdateResMgrArrow()
	{
	}

	[Token(Token = "0x60051F7")]
	[Address(RVA = "0x29B53F8", Offset = "0x29B53F8", VA = "0x29B53F8")]
	private void OMOEPJODJPL()
	{
	}

	[Token(Token = "0x60051F8")]
	[Address(RVA = "0x29BC860", Offset = "0x29BC860", VA = "0x29BC860")]
	private void DGPIAEAMPJL()
	{
	}

	[Token(Token = "0x60051F9")]
	[Address(RVA = "0x29BBBD0", Offset = "0x29BBBD0", VA = "0x29BBBD0")]
	public void UnSelectModifyItem()
	{
	}

	[Token(Token = "0x60051FA")]
	[Address(RVA = "0x29BCD64", Offset = "0x29BCD64", VA = "0x29BCD64")]
	public void RemoveGroupObj(SceneEditObjectBase ECINOMEHBKA)
	{
	}

	[Token(Token = "0x60051FB")]
	[Address(RVA = "0x29BCE00", Offset = "0x29BCE00", VA = "0x29BCE00")]
	public bool HasItemInModify()
	{
		return default(bool);
	}

	[Token(Token = "0x60051FC")]
	[Address(RVA = "0x29B9F3C", Offset = "0x29B9F3C", VA = "0x29B9F3C")]
	public ItemEditAttributeBaseConfig CheckAndGetItemAttributeConfig(SceneEditPrefabConfigData JHENJMANOEL)
	{
		return null;
	}

	[Token(Token = "0x60051FD")]
	[Address(RVA = "0x29BCED4", Offset = "0x29BCED4", VA = "0x29BCED4")]
	public List<ItemEditAttributeUIData> CheckAndGetItemAttributeUIData(uint CJDMCMOODAH, ItemEditAttributeBaseConfig INAAMBKNFLL)
	{
		return null;
	}

	[Token(Token = "0x60051FE")]
	[Address(RVA = "0x29BAFB8", Offset = "0x29BAFB8", VA = "0x29BAFB8")]
	public void RefreshCurEditObjectAttributeData(SceneEditPrefabConfigData JHENJMANOEL, [Optional] SceneEditObjectBase CGDAFHNPMFB)
	{
	}

	[Token(Token = "0x60051FF")]
	[Address(RVA = "0x29BD084", Offset = "0x29BD084", VA = "0x29BD084")]
	public ItemFunctionAttributeBaseConfig CheckAndGetItemFuncAttributeConfig(SceneEditPrefabConfigData JHENJMANOEL)
	{
		return null;
	}

	[Token(Token = "0x6005200")]
	[Address(RVA = "0x29BD324", Offset = "0x29BD324", VA = "0x29BD324")]
	public void OnSceneEditItemTypeChange()
	{
	}

	[Token(Token = "0x6005201")]
	[Address(RVA = "0x29BA1DC", Offset = "0x29BA1DC", VA = "0x29BA1DC")]
	public void OnPrefabSelected(SceneEditPrefabConfigData JHENJMANOEL)
	{
	}

	[Token(Token = "0x6005202")]
	[Address(RVA = "0x29BDEE8", Offset = "0x29BDEE8", VA = "0x29BDEE8")]
	public bool HasCustomExtraAttributeData(uint AOHJFKHIHII)
	{
		return default(bool);
	}

	[Token(Token = "0x6005203")]
	[Address(RVA = "0x29BDF64", Offset = "0x29BDF64", VA = "0x29BDF64")]
	public void OnCrosshairScaleChanged()
	{
	}

	[Token(Token = "0x6005204")]
	[Address(RVA = "0x29BE0CC", Offset = "0x29BE0CC", VA = "0x29BE0CC")]
	public bool CanPutDownNewObject()
	{
		return default(bool);
	}

	[Token(Token = "0x6005205")]
	[Address(RVA = "0x29BE288", Offset = "0x29BE288", VA = "0x29BE288")]
	private void DJOMJMPLLLM(SceneEditCrosshair AHKMAFMANAE, SceneEditObjectBase ECINOMEHBKA, bool EIDBGFCGCGC = false)
	{
	}

	[Token(Token = "0x6005206")]
	[Address(RVA = "0x29BE5CC", Offset = "0x29BE5CC", VA = "0x29BE5CC")]
	public void OnPutDownClicked()
	{
	}

	[Token(Token = "0x6005207")]
	[Address(RVA = "0x29BED40", Offset = "0x29BED40", VA = "0x29BED40")]
	public void SetCustomPoint(SceneEditCrosshair ICJNPAPFKMB)
	{
	}

	[Token(Token = "0x6005208")]
	[Address(RVA = "0x29BF4F0", Offset = "0x29BF4F0", VA = "0x29BF4F0")]
	private void IBHHNLALIHO()
	{
	}

	[Token(Token = "0x6005209")]
	[Address(RVA = "0x29BF24C", Offset = "0x29BF24C", VA = "0x29BF24C")]
	public void RedirectCustomPointPath(SceneEditObjectBase MAFKLPJGIEH)
	{
	}

	[Token(Token = "0x600520A")]
	[Address(RVA = "0x29BF9A0", Offset = "0x29BF9A0", VA = "0x29BF9A0")]
	public void OnRotateCrosshairClicked()
	{
	}

	[Token(Token = "0x600520B")]
	[Address(RVA = "0x29BD490", Offset = "0x29BD490", VA = "0x29BD490")]
	public void OnCancelCrosshairClicked()
	{
	}

	[Token(Token = "0x600520C")]
	[Address(RVA = "0x29C0218", Offset = "0x29C0218", VA = "0x29C0218")]
	public void OnModifyBtnMove()
	{
	}

	[Token(Token = "0x600520D")]
	[Address(RVA = "0x29C0870", Offset = "0x29C0870", VA = "0x29C0870")]
	private void NJIJPCPCCJH(SceneEditObjectBase DFKHBJAKAOK, Vector3 IKCCPFOIHEM, bool FANNKIKGFNF, bool PKJAAOKNDEL = false, int EDDEJIHKPBO = -1)
	{
	}

	[Token(Token = "0x600520E")]
	[Address(RVA = "0x29C20A0", Offset = "0x29C20A0", VA = "0x29C20A0")]
	public void OnAdjustFloorPlaneMove(bool AAGCANOHMMA)
	{
	}

	[Token(Token = "0x600520F")]
	[Address(RVA = "0x29C2478", Offset = "0x29C2478", VA = "0x29C2478")]
	public List<ItemEditAttributeCacheValueBase> GenItemEditAttributeCacheValue(SceneEditPrefabConfigData JHENJMANOEL, [Optional] SceneEditObjectBase KNOMAAGPIKH)
	{
		return null;
	}

	[Token(Token = "0x6005210")]
	[Address(RVA = "0x29C27A0", Offset = "0x29C27A0", VA = "0x29C27A0")]
	public void NotifyItemAttributeChanged()
	{
	}

	[Token(Token = "0x6005211")]
	[Address(RVA = "0x29BB348", Offset = "0x29BB348", VA = "0x29BB348")]
	private void JHJGGFHFHIK(SceneEditObjectAttrBase LMICHPEENDG, SceneEditPrefabConfigData JHENJMANOEL)
	{
	}

	[Token(Token = "0x6005212")]
	[Address(RVA = "0x29C2C44", Offset = "0x29C2C44", VA = "0x29C2C44")]
	private bool JCKOKFOMJOA(SceneEditObjectBase DFKHBJAKAOK)
	{
		return default(bool);
	}

	[Token(Token = "0x6005213")]
	[Address(RVA = "0x29C3450", Offset = "0x29C3450", VA = "0x29C3450")]
	public void OnModifyBtnDuplicate()
	{
	}

	[Token(Token = "0x6005214")]
	[Address(RVA = "0x29B5BD4", Offset = "0x29B5BD4", VA = "0x29B5BD4")]
	public void OnModifyBtnDelete()
	{
	}

	[Token(Token = "0x6005215")]
	[Address(RVA = "0x29C3C7C", Offset = "0x29C3C7C", VA = "0x29C3C7C")]
	public void OnClearAllObjects()
	{
	}

	[Token(Token = "0x6005216")]
	[Address(RVA = "0x29C3CF0", Offset = "0x29C3CF0", VA = "0x29C3CF0")]
	public Vector3 FixPositionByGrid(Vector3 ACCOJJMKKPM, Vector3 ELAEOLJIELN, List<Collider> OAMCDEPOPPH, float ALMFPDGLJEL)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6005217")]
	[Address(RVA = "0x29C4084", Offset = "0x29C4084", VA = "0x29C4084")]
	public void SwitchResMgrMode(bool GIKMGIJCDOP, bool JMDNGPLCCKH = false)
	{
	}

	[Token(Token = "0x6005218")]
	[Address(RVA = "0x29C4354", Offset = "0x29C4354", VA = "0x29C4354")]
	public void SwitchGruopMode(bool OFCHDIPNJGL)
	{
	}

	[Token(Token = "0x6005219")]
	[Address(RVA = "0x29C4540", Offset = "0x29C4540", VA = "0x29C4540")]
	public void ShowGridLine(bool ODOEHEHNJOG)
	{
	}

	[Token(Token = "0x600521A")]
	[Address(RVA = "0x29C49AC", Offset = "0x29C49AC", VA = "0x29C49AC")]
	public void ChangeCameraMode(FFDCDKNGNDC HPKCDJLHEFO)
	{
	}

	[Token(Token = "0x600521B")]
	[Address(RVA = "0x29C53EC", Offset = "0x29C53EC", VA = "0x29C53EC")]
	public void SetAgentEditMode(DNLNDBDCGHM DHPFPFKOECK)
	{
	}

	[Token(Token = "0x600521C")]
	[Address(RVA = "0x29C4E44", Offset = "0x29C4E44", VA = "0x29C4E44")]
	public void SetAgentFreeCamProjection(NKDDKDPPCGG KCGGBBIOOBL)
	{
	}

	[Token(Token = "0x600521D")]
	[Address(RVA = "0x29C5720", Offset = "0x29C5720", VA = "0x29C5720")]
	public bool IsCurProjectionPerspective()
	{
		return default(bool);
	}

	[Token(Token = "0x600521E")]
	[Address(RVA = "0x29C5688", Offset = "0x29C5688", VA = "0x29C5688")]
	private void BCIINONOEGF(Camera IFPMCEFKDEC)
	{
	}

	[Token(Token = "0x600521F")]
	[Address(RVA = "0x29C578C", Offset = "0x29C578C", VA = "0x29C578C")]
	public float CalLineSizeRatio()
	{
		return default(float);
	}

	[Token(Token = "0x6005220")]
	[Address(RVA = "0x29C5914", Offset = "0x29C5914", VA = "0x29C5914")]
	public void KeepCamTran()
	{
	}

	[Token(Token = "0x6005221")]
	[Address(RVA = "0x29C5B64", Offset = "0x29C5B64", VA = "0x29C5B64")]
	public bool IsSelectedInGroupAndNotCurFloor()
	{
		return default(bool);
	}

	[Token(Token = "0x6005222")]
	[Address(RVA = "0x29C5D18", Offset = "0x29C5D18", VA = "0x29C5D18")]
	public void OnSceneEditObjectPicked(SceneEditObjectBase ECINOMEHBKA)
	{
	}

	[Token(Token = "0x6005223")]
	[Address(RVA = "0x29C5EBC", Offset = "0x29C5EBC", VA = "0x29C5EBC")]
	public void AddEntityAfterCreateSceneEditObject(SceneEditObjectBase DFKHBJAKAOK, FSceneEditObjectData JFNNBFCGHIB, SceneEditPrefabConfigData KIGCLMKLBKF)
	{
	}

	[Token(Token = "0x6005224")]
	[Address(RVA = "0x29C6694", Offset = "0x29C6694", VA = "0x29C6694")]
	public void SetCrossHairColor(Color GBDCICHCNFC, PNDELHDACMC PMGBACFJIHO)
	{
	}

	[Token(Token = "0x6005225")]
	[Address(RVA = "0x29C6800", Offset = "0x29C6800", VA = "0x29C6800")]
	public void SetCrossHairColorActive(bool GIKMGIJCDOP)
	{
	}

	[Token(Token = "0x6005226")]
	[Address(RVA = "0x29C6CF4", Offset = "0x29C6CF4", VA = "0x29C6CF4")]
	public void AddEntityAfterCreateSceneEditObject(SceneEditObjectBase DFKHBJAKAOK, EJHLCKLOFKD PJJKOLEJHEM, SceneEditPrefabConfigData KIGCLMKLBKF)
	{
	}

	[Token(Token = "0x6005227")]
	[Address(RVA = "0x29BD968", Offset = "0x29BD968", VA = "0x29BD968")]
	public void AddEntityAfterCreateSceneEditAttrObject(SceneEditObjectAttrBase MPJLPAIFEII, SceneEditPrefabConfigData KIGCLMKLBKF)
	{
	}

	[Token(Token = "0x6005228")]
	[Address(RVA = "0x29C71B0", Offset = "0x29C71B0", VA = "0x29C71B0")]
	public void EnterContinuousDeleting(bool LNADELIDMNN)
	{
	}

	[Token(Token = "0x6005229")]
	[Address(RVA = "0x29B360C", Offset = "0x29B360C", VA = "0x29B360C")]
	private void JKPONPDCKMI()
	{
	}

	[Token(Token = "0x600522A")]
	[Address(RVA = "0x29B3C2C", Offset = "0x29B3C2C", VA = "0x29B3C2C")]
	private void FGMAPCMEDOA()
	{
	}

	[Token(Token = "0x600522B")]
	[Address(RVA = "0x29BB500", Offset = "0x29BB500", VA = "0x29BB500")]
	private void PKPDILCGAJN(Vector3 PFAPJJODMCM)
	{
	}

	[Token(Token = "0x600522C")]
	[Address(RVA = "0x29C7408", Offset = "0x29C7408", VA = "0x29C7408")]
	public void ResetAgentRotation()
	{
	}

	[Token(Token = "0x600522D")]
	[Address(RVA = "0x29C77B4", Offset = "0x29C77B4", VA = "0x29C77B4", Slot = "6")]
	public Quaternion GetCameraTrackableEntityAimRotation()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}

	[Token(Token = "0x600522E")]
	[Address(RVA = "0x29C7874", Offset = "0x29C7874", VA = "0x29C7874", Slot = "4")]
	public Vector3 GetCameraTrackableEntityPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600522F")]
	[Address(RVA = "0x29C7934", Offset = "0x29C7934", VA = "0x29C7934", Slot = "5")]
	public Vector3 GetCameraTrackableEntityTopPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6005230")]
	[Address(RVA = "0x29C79FC", Offset = "0x29C79FC", VA = "0x29C79FC", Slot = "7")]
	public Transform GetCameraTrackableEntityTransfrom()
	{
		return null;
	}

	[Token(Token = "0x6005231")]
	[Address(RVA = "0x29C7A8C", Offset = "0x29C7A8C", VA = "0x29C7A8C", Slot = "8")]
	public bool IsCameraTrackableEntityAlive()
	{
		return default(bool);
	}

	[Token(Token = "0x6005232")]
	[Address(RVA = "0x29C7AE8", Offset = "0x29C7AE8", VA = "0x29C7AE8")]
	public void SwitchFreeCameProjection()
	{
	}

	[Token(Token = "0x6005233")]
	[Address(RVA = "0x29C80D8", Offset = "0x29C80D8", VA = "0x29C80D8")]
	public bool IsDuringSwitch()
	{
		return default(bool);
	}

	[Token(Token = "0x6005234")]
	[Address(RVA = "0x29C8130", Offset = "0x29C8130", VA = "0x29C8130")]
	public float GetAgentHeightOrSizeRatio()
	{
		return default(float);
	}

	[Token(Token = "0x6005235")]
	[Address(RVA = "0x29C83B8", Offset = "0x29C83B8", VA = "0x29C83B8")]
	public void SetAgentHeightOrSizeRatio(float LGHNJEDOFFD)
	{
	}

	[Token(Token = "0x6005236")]
	[Address(RVA = "0x29C86C4", Offset = "0x29C86C4", VA = "0x29C86C4")]
	public void SetAgentHeightByOffset(float AHMEIFIGKFB)
	{
	}

	[Token(Token = "0x6005237")]
	[Address(RVA = "0x29B5DBC", Offset = "0x29B5DBC", VA = "0x29B5DBC")]
	private void IMEHMEOBENM()
	{
	}

	[Token(Token = "0x6005238")]
	[Address(RVA = "0x29C89E0", Offset = "0x29C89E0", VA = "0x29C89E0")]
	public void MoveDirection(OJLNGFLPIEA CECACOBDFEP, bool DEFNLOJEGIF)
	{
	}

	[Token(Token = "0x6005239")]
	[Address(RVA = "0x29C931C", Offset = "0x29C931C", VA = "0x29C931C")]
	private void FLNCHCANHKM()
	{
	}
}
