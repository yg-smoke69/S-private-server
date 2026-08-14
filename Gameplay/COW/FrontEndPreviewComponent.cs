using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002C8A")]
public class FrontEndPreviewComponent
{
	[Token(Token = "0x2002C8B")]
	public enum ShowPreviewType
	{
		[Token(Token = "0x401103D")]
		None,
		[Token(Token = "0x401103E")]
		ID,
		[Token(Token = "0x401103F")]
		ClothList,
		[Token(Token = "0x4011040")]
		DoubleAvatar
	}

	[Token(Token = "0x2002C8C")]
	public enum PetType
	{
		[Token(Token = "0x4011042")]
		Default,
		[Token(Token = "0x4011043")]
		Cat,
		[Token(Token = "0x4011044")]
		Dog,
		[Token(Token = "0x4011045")]
		Panther,
		[Token(Token = "0x4011046")]
		Panda,
		[Token(Token = "0x4011047")]
		ShiBa,
		[Token(Token = "0x4011048")]
		Fox,
		[Token(Token = "0x4011049")]
		Robot,
		[Token(Token = "0x401104A")]
		Poring,
		[Token(Token = "0x401104B")]
		Otter,
		[Token(Token = "0x401104C")]
		Hawk,
		[Token(Token = "0x401104D")]
		PenGuin,
		[Token(Token = "0x401104E")]
		Raccoon,
		[Token(Token = "0x401104F")]
		Baboon,
		[Token(Token = "0x4011050")]
		Dragon,
		[Token(Token = "0x4011051")]
		Alien,
		[Token(Token = "0x4011052")]
		Duck,
		[Token(Token = "0x4011053")]
		Tiger,
		[Token(Token = "0x4011054")]
		Rabbit
	}

	[Token(Token = "0x2002C8D")]
	public enum PreviewConfigType
	{
		[Token(Token = "0x4011056")]
		Normal
	}

	[Token(Token = "0x2002C8E")]
	public enum Cameratype
	{
		[Token(Token = "0x4011058")]
		None,
		[Token(Token = "0x4011059")]
		AvatarCamera,
		[Token(Token = "0x401105A")]
		ItemCamera,
		[Token(Token = "0x401105B")]
		MixCamera
	}

	[Token(Token = "0x2002C8F")]
	public enum AnimType
	{
		[Token(Token = "0x401105D")]
		SpecialAnim = 1,
		[Token(Token = "0x401105E")]
		FullCG,
		[Token(Token = "0x401105F")]
		SkinShowAnim
	}

	[Token(Token = "0x2002C90")]
	public enum AvatarType
	{
		[Token(Token = "0x4011061")]
		localAvatar,
		[Token(Token = "0x4011062")]
		AvatarWithNoCache,
		[Token(Token = "0x4011063")]
		AvatarWithCache,
		[Token(Token = "0x4011064")]
		AvatarWithNoPool
	}

	[Token(Token = "0x2002C91")]
	public enum CollectionPreviewType
	{
		[Token(Token = "0x4011066")]
		BackPack,
		[Token(Token = "0x4011067")]
		BootyBox,
		[Token(Token = "0x4011068")]
		ParaChute,
		[Token(Token = "0x4011069")]
		SkyBoard,
		[Token(Token = "0x401106A")]
		WeaponSkin,
		[Token(Token = "0x401106B")]
		VehicleSkin,
		[Token(Token = "0x401106C")]
		WeaponMeleeSkin,
		[Token(Token = "0x401106D")]
		WeaponGrenadeSkin,
		[Token(Token = "0x401106E")]
		Emote,
		[Token(Token = "0x401106F")]
		RedEnvelope,
		[Token(Token = "0x4011070")]
		PetCat,
		[Token(Token = "0x4011071")]
		Flight,
		[Token(Token = "0x4011072")]
		GroupAnim,
		[Token(Token = "0x4011073")]
		Camera,
		[Token(Token = "0x4011074")]
		HyperBook,
		[Token(Token = "0x4011075")]
		WeaponIceWall,
		[Token(Token = "0x4011076")]
		WeaponSmokeGranede
	}

	[Token(Token = "0x2002C92")]
	public enum PetPreviewType
	{
		[Token(Token = "0x4011078")]
		PetModel = 0,
		[Token(Token = "0x4011079")]
		PetSkin = 10,
		[Token(Token = "0x401107A")]
		PetRation = 7,
		[Token(Token = "0x401107B")]
		PetAnima = 9
	}

	[Token(Token = "0x2002C93")]
	private sealed class _003CShowHyperBook_003Ec__AnonStorey0
	{
		[Token(Token = "0x401107C")]
		[FieldOffset(Offset = "0x8")]
		internal ResourceID previewRes;

		[Token(Token = "0x401107D")]
		[FieldOffset(Offset = "0xC")]
		internal Transform tmpTrans;

		[Token(Token = "0x401107E")]
		[FieldOffset(Offset = "0x10")]
		internal FrontEndPreviewComponent _0024this;

		[Token(Token = "0x6012A1E")]
		[Address(RVA = "0x104830C", Offset = "0x104830C", VA = "0x104830C")]
		public _003CShowHyperBook_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6012A1F")]
		[Address(RVA = "0x1048314", Offset = "0x1048314", VA = "0x1048314")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4010FF6")]
	protected const uint ISVISIBLE_COMMON = 1u;

	[Token(Token = "0x4010FF7")]
	protected const uint ISVISIBLE_ANIMATION = 2u;

	[Token(Token = "0x4010FF8")]
	protected const string WEAPON360DEGREENAME = "weaponempty";

	[Token(Token = "0x4010FF9")]
	private const uint GRENADEWEAPONID = 601u;

	[Token(Token = "0x4010FFA")]
	[FieldOffset(Offset = "0x8")]
	protected ECollectionLevel m_CurrentBagpackLevel;

	[Token(Token = "0x4010FFB")]
	[FieldOffset(Offset = "0xC")]
	protected UIBaseController m_ParentController;

	[Token(Token = "0x4010FFC")]
	[FieldOffset(Offset = "0x10")]
	protected GameObject m_ItemCameraGo;

	[Token(Token = "0x4010FFD")]
	[FieldOffset(Offset = "0x14")]
	protected Camera m_ItemCamera;

	[Token(Token = "0x4010FFE")]
	[FieldOffset(Offset = "0x18")]
	protected PreviewCameraMove m_ItemCameraMove;

	[Token(Token = "0x4010FFF")]
	[FieldOffset(Offset = "0x1C")]
	protected GameObject m_MixCameraGo;

	[Token(Token = "0x4011000")]
	[FieldOffset(Offset = "0x20")]
	protected Camera m_MixCamera;

	[Token(Token = "0x4011001")]
	[FieldOffset(Offset = "0x24")]
	protected PreviewCameraMove m_MixCameraMove;

	[Token(Token = "0x4011002")]
	[FieldOffset(Offset = "0x28")]
	protected GameObject m_TouchArea;

	[Token(Token = "0x4011003")]
	[FieldOffset(Offset = "0x2C")]
	protected GameObject m_Preview3DItem;

	[Token(Token = "0x4011004")]
	[FieldOffset(Offset = "0x30")]
	protected UIMaleAvatar m_PreviewAvatar;

	[Token(Token = "0x4011005")]
	[FieldOffset(Offset = "0x34")]
	protected UIMaleAvatar m_PreviewAvatar2P;

	[Token(Token = "0x4011006")]
	[FieldOffset(Offset = "0x38")]
	protected UIMaleAvatar m_PreviewCachedAvatar;

	[Token(Token = "0x4011007")]
	[FieldOffset(Offset = "0x3C")]
	protected UIPetAvatar m_PetAvatar;

	[Token(Token = "0x4011008")]
	[FieldOffset(Offset = "0x40")]
	private FrontendPreviewType _003CPreviewType_003Ek__BackingField;

	[Token(Token = "0x4011009")]
	[FieldOffset(Offset = "0x44")]
	private Cameratype _003CMyCameratype_003Ek__BackingField;

	[Token(Token = "0x401100A")]
	[FieldOffset(Offset = "0x48")]
	private bool _003CIsPreviewOpen_003Ek__BackingField;

	[Token(Token = "0x401100B")]
	[FieldOffset(Offset = "0x49")]
	private bool _003CIsPreviewHiding_003Ek__BackingField;

	[Token(Token = "0x401100C")]
	[FieldOffset(Offset = "0x4A")]
	private bool isSpecialPack;

	[Token(Token = "0x401100D")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelStoreBox m_modelStoreBox;

	[Token(Token = "0x401100E")]
	[FieldOffset(Offset = "0x50")]
	private UIModelHyperBook m_modelHyperBook;

	[Token(Token = "0x401100F")]
	[FieldOffset(Offset = "0x54")]
	protected UIModelAvatar m_ModelAvatar;

	[Token(Token = "0x4011010")]
	[FieldOffset(Offset = "0x58")]
	private Quaternion _003CWeaponOriginQuatertion_003Ek__BackingField;

	[Token(Token = "0x4011011")]
	[FieldOffset(Offset = "0x68")]
	private bool _003CIgnoreManualChange_003Ek__BackingField;

	[Token(Token = "0x4011012")]
	[FieldOffset(Offset = "0x6C")]
	private UIFrontEndPreviewController _003CPreviewUIController_003Ek__BackingField;

	[Token(Token = "0x4011013")]
	[FieldOffset(Offset = "0x0")]
	protected static FrontEndPreviewConfig m_Preconfig;

	[Token(Token = "0x4011014")]
	[FieldOffset(Offset = "0x70")]
	protected GameObject m_PreviewCG;

	[Token(Token = "0x4011015")]
	[FieldOffset(Offset = "0x74")]
	protected GameObject m_GroundShadow;

	[Token(Token = "0x4011016")]
	[FieldOffset(Offset = "0x78")]
	protected UIFrontEndPreviewWeaponZoomInController m_ZoomInController;

	[Token(Token = "0x4011017")]
	[FieldOffset(Offset = "0x7C")]
	protected UIFrontEndPreviewZoomInWithCameraController m_ZoomInWithCameraController;

	[Token(Token = "0x4011018")]
	[FieldOffset(Offset = "0x80")]
	protected uint m_MarkDoubleAnimCount;

	[Token(Token = "0x4011019")]
	[FieldOffset(Offset = "0x84")]
	protected List<GameObject> m_WeaponPreviewShowList;

	[Token(Token = "0x401101A")]
	[FieldOffset(Offset = "0x88")]
	protected FrontEndPreviewAvatarParams m_PreviewAvatarParams;

	[Token(Token = "0x401101B")]
	[FieldOffset(Offset = "0x8C")]
	protected bool m_isShowWeaponNotification;

	[Token(Token = "0x401101C")]
	[FieldOffset(Offset = "0x90")]
	protected List<Vector3> m_PreviewCgScaleList;

	[Token(Token = "0x401101D")]
	[FieldOffset(Offset = "0x94")]
	protected Camera bg_camera;

	[Token(Token = "0x401101E")]
	[FieldOffset(Offset = "0x98")]
	protected ResourceRefCache m_3dModelRefCache;

	[Token(Token = "0x401101F")]
	[FieldOffset(Offset = "0x9C")]
	private uint _003CShowWeaponid_003Ek__BackingField;

	[Token(Token = "0x4011020")]
	[FieldOffset(Offset = "0xA0")]
	private double m_PauseTime;

	[Token(Token = "0x4011021")]
	[FieldOffset(Offset = "0xA8")]
	protected FrontEndPreviewConfigData m_FrontEndPreviewConfigData;

	[Token(Token = "0x4011022")]
	[FieldOffset(Offset = "0xAC")]
	protected FrontEndPreviewUIConfigData m_FrontEndPreviewUIConfigData;

	[Token(Token = "0x4011023")]
	[FieldOffset(Offset = "0xB0")]
	protected ShowPreviewType m_CurrentShowPreviewType;

	[Token(Token = "0x4011024")]
	[FieldOffset(Offset = "0xB4")]
	protected PreviewShowAvatarParams m_CurrentShowAvatarParams;

	[Token(Token = "0x4011025")]
	[FieldOffset(Offset = "0xCC")]
	protected PreviewShowItemParams m_CurrentShowIDParams;

	[Token(Token = "0x4011026")]
	[FieldOffset(Offset = "0xD4")]
	protected PreviewShowDoubleAvatarParams m_CurrentDoubleAvatarParams;

	[Token(Token = "0x4011027")]
	[FieldOffset(Offset = "0xDC")]
	private uint m_CustomAvatarIdF;

	[Token(Token = "0x4011028")]
	[FieldOffset(Offset = "0xE0")]
	private uint m_CustomAvatarIdM;

	[Token(Token = "0x4011029")]
	[FieldOffset(Offset = "0xE4")]
	private uint m_DelayCallHyperBookAnim;

	[Token(Token = "0x401102A")]
	[FieldOffset(Offset = "0xE8")]
	private Dictionary<uint, uint> m_PreviewTypeToEFrontendUITypeDic;

	[Token(Token = "0x401102B")]
	[FieldOffset(Offset = "0xEC")]
	protected Dictionary<uint, int> m_PreviewPetIDToPetTypeDic;

	[Token(Token = "0x401102C")]
	[FieldOffset(Offset = "0xF0")]
	protected Dictionary<int, PreviewPetConfig> m_PreviewPetAvatarConfigDic;

	[Token(Token = "0x401102D")]
	[FieldOffset(Offset = "0xF4")]
	private Dictionary<uint, PreviewWeaponConfig> m_PreviewWeaponConfigDic;

	[Token(Token = "0x401102E")]
	[FieldOffset(Offset = "0xF8")]
	private List<uint> m_PreviewWeaponNotNeed360Degree;

	[Token(Token = "0x401102F")]
	[FieldOffset(Offset = "0xFC")]
	private uint m_BundleIDIamIn;

	[Token(Token = "0x4011030")]
	[FieldOffset(Offset = "0x100")]
	private bool m_IsShowDescription;

	[Token(Token = "0x4011031")]
	[FieldOffset(Offset = "0x101")]
	private bool m_IsShowOwned;

	[Token(Token = "0x4011032")]
	[FieldOffset(Offset = "0x104")]
	private FullScreenAnimParams m_Animdata;

	[Token(Token = "0x4011033")]
	[FieldOffset(Offset = "0x108")]
	private bool m_ShowBundleScrollView;

	[Token(Token = "0x4011034")]
	[FieldOffset(Offset = "0x109")]
	private bool m_PlayAnimation;

	[Token(Token = "0x4011035")]
	[FieldOffset(Offset = "0x10A")]
	private bool m_ShowBundleTitle;

	[Token(Token = "0x4011036")]
	[FieldOffset(Offset = "0x10B")]
	private bool m_NeedResetAvatarDiretion;

	[Token(Token = "0x4011037")]
	[FieldOffset(Offset = "0x10C")]
	private bool m_NeedResetUI;

	[Token(Token = "0x4011038")]
	[FieldOffset(Offset = "0x10D")]
	private bool m_NeedShowInstallmentInfo;

	[Token(Token = "0x4011039")]
	[FieldOffset(Offset = "0x10E")]
	private bool m_NeedDownload;

	[Token(Token = "0x401103A")]
	[FieldOffset(Offset = "0x110")]
	private DownloadInfoSpecific m_DownloadInfo;

	[Token(Token = "0x401103B")]
	[FieldOffset(Offset = "0x4")]
	private static ShowBoostAvatarParams.CheckBoostStateDelegate _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17001331")]
	public ECollectionLevel CurrentCollectionLevel
	{
		[Token(Token = "0x6012923")]
		[Address(RVA = "0xDFBC60", Offset = "0xDFBC60", VA = "0xDFBC60")]
		get
		{
			return default(ECollectionLevel);
		}
	}

	[Token(Token = "0x17001332")]
	public Camera MixCamera
	{
		[Token(Token = "0x6012924")]
		[Address(RVA = "0xDFBCB8", Offset = "0xDFBCB8", VA = "0xDFBCB8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001333")]
	public Camera ItemCamera
	{
		[Token(Token = "0x6012925")]
		[Address(RVA = "0xDFBD10", Offset = "0xDFBD10", VA = "0xDFBD10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001334")]
	public GameObject Preview3DItem
	{
		[Token(Token = "0x6012926")]
		[Address(RVA = "0xDFBD68", Offset = "0xDFBD68", VA = "0xDFBD68")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001335")]
	public UIMaleAvatar PreviewCachedAvatar
	{
		[Token(Token = "0x6012927")]
		[Address(RVA = "0xDFBDC0", Offset = "0xDFBDC0", VA = "0xDFBDC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001336")]
	public UIPetAvatar PetAvatar
	{
		[Token(Token = "0x6012928")]
		[Address(RVA = "0xDFBE18", Offset = "0xDFBE18", VA = "0xDFBE18")]
		get
		{
			return null;
		}
		[Token(Token = "0x6012929")]
		[Address(RVA = "0xDFBE70", Offset = "0xDFBE70", VA = "0xDFBE70")]
		set
		{
		}
	}

	[Token(Token = "0x17001337")]
	public FrontendPreviewType PreviewType
	{
		[Token(Token = "0x601292A")]
		[Address(RVA = "0xDFBED0", Offset = "0xDFBED0", VA = "0xDFBED0")]
		get
		{
			return default(FrontendPreviewType);
		}
		[Token(Token = "0x601292B")]
		[Address(RVA = "0xDFBED8", Offset = "0xDFBED8", VA = "0xDFBED8")]
		private set
		{
		}
	}

	[Token(Token = "0x17001338")]
	public Cameratype MyCameratype
	{
		[Token(Token = "0x601292C")]
		[Address(RVA = "0xDFBEE0", Offset = "0xDFBEE0", VA = "0xDFBEE0")]
		get
		{
			return default(Cameratype);
		}
		[Token(Token = "0x601292D")]
		[Address(RVA = "0xDFBEE8", Offset = "0xDFBEE8", VA = "0xDFBEE8")]
		private set
		{
		}
	}

	[Token(Token = "0x17001339")]
	public bool IsPreviewOpen
	{
		[Token(Token = "0x601292E")]
		[Address(RVA = "0xDFBEF0", Offset = "0xDFBEF0", VA = "0xDFBEF0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601292F")]
		[Address(RVA = "0xDFBEF8", Offset = "0xDFBEF8", VA = "0xDFBEF8")]
		private set
		{
		}
	}

	[Token(Token = "0x1700133A")]
	public bool IsPreviewHiding
	{
		[Token(Token = "0x6012930")]
		[Address(RVA = "0xDFBF00", Offset = "0xDFBF00", VA = "0xDFBF00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6012931")]
		[Address(RVA = "0xDFBF08", Offset = "0xDFBF08", VA = "0xDFBF08")]
		private set
		{
		}
	}

	[Token(Token = "0x1700133B")]
	public Quaternion WeaponOriginQuatertion
	{
		[Token(Token = "0x6012932")]
		[Address(RVA = "0xDFBF10", Offset = "0xDFBF10", VA = "0xDFBF10")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}
		[Token(Token = "0x6012933")]
		[Address(RVA = "0xDFBF20", Offset = "0xDFBF20", VA = "0xDFBF20")]
		private set
		{
		}
	}

	[Token(Token = "0x1700133C")]
	public bool IgnoreManualChange
	{
		[Token(Token = "0x6012934")]
		[Address(RVA = "0xDFBF30", Offset = "0xDFBF30", VA = "0xDFBF30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6012935")]
		[Address(RVA = "0xDFBF38", Offset = "0xDFBF38", VA = "0xDFBF38")]
		set
		{
		}
	}

	[Token(Token = "0x1700133D")]
	public UIFrontEndPreviewController PreviewUIController
	{
		[Token(Token = "0x6012936")]
		[Address(RVA = "0xDFBF40", Offset = "0xDFBF40", VA = "0xDFBF40")]
		get
		{
			return null;
		}
		[Token(Token = "0x6012937")]
		[Address(RVA = "0xDFBF48", Offset = "0xDFBF48", VA = "0xDFBF48")]
		private set
		{
		}
	}

	[Token(Token = "0x1700133E")]
	public GameObject PreviewCG
	{
		[Token(Token = "0x6012938")]
		[Address(RVA = "0xDFBF50", Offset = "0xDFBF50", VA = "0xDFBF50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700133F")]
	public uint ShowWeaponid
	{
		[Token(Token = "0x6012939")]
		[Address(RVA = "0xDFBFA8", Offset = "0xDFBFA8", VA = "0xDFBFA8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601293A")]
		[Address(RVA = "0xDFBFB0", Offset = "0xDFBFB0", VA = "0xDFBFB0")]
		set
		{
		}
	}

	[Token(Token = "0x17001340")]
	public uint CustomShowAvatarF
	{
		[Token(Token = "0x601293B")]
		[Address(RVA = "0xDFBFB8", Offset = "0xDFBFB8", VA = "0xDFBFB8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601293C")]
		[Address(RVA = "0xDFC010", Offset = "0xDFC010", VA = "0xDFC010")]
		set
		{
		}
	}

	[Token(Token = "0x17001341")]
	public uint CustomShowAvatarM
	{
		[Token(Token = "0x601293D")]
		[Address(RVA = "0xDFC070", Offset = "0xDFC070", VA = "0xDFC070")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601293E")]
		[Address(RVA = "0xDFC0C8", Offset = "0xDFC0C8", VA = "0xDFC0C8")]
		set
		{
		}
	}

	[Token(Token = "0x6012922")]
	[Address(RVA = "0xDFAF9C", Offset = "0xDFAF9C", VA = "0xDFAF9C")]
	public FrontEndPreviewComponent()
	{
	}

	[Token(Token = "0x601293F")]
	[Address(RVA = "0xDFC128", Offset = "0xDFC128", VA = "0xDFC128")]
	public void SetPreviewPetConfig(PetType petType, PreviewPetConfig config)
	{
	}

	[Token(Token = "0x6012940")]
	[Address(RVA = "0xDFC294", Offset = "0xDFC294", VA = "0xDFC294")]
	public void Init()
	{
	}

	[Token(Token = "0x6012941")]
	[Address(RVA = "0xDFC638", Offset = "0xDFC638", VA = "0xDFC638")]
	private void SetPreviewMoveBg()
	{
	}

	[Token(Token = "0x6012942")]
	[Address(RVA = "0xDFC904", Offset = "0xDFC904", VA = "0xDFC904")]
	public void OpenPreview(UIBaseController parentController, UIFrontEndPreviewController previewItemController, FrontEndPreviewConfigData frontEndPreviewData)
	{
	}

	[Token(Token = "0x6012943")]
	[Address(RVA = "0xDFDA88", Offset = "0xDFDA88", VA = "0xDFDA88")]
	public void SetAvatarParams(Vector3 scale, Vector3 pos, AvatarType type, Vector4 boostparams, bool Playpose = true, bool needStopEffect = true, [Optional] ShowBoostAvatarParams showBoostAvatarParams)
	{
	}

	[Token(Token = "0x6012944")]
	[Address(RVA = "0xDFDC44", Offset = "0xDFDC44", VA = "0xDFDC44")]
	public GameObject GetItemCarmea()
	{
		return null;
	}

	[Token(Token = "0x6012945")]
	[Address(RVA = "0xDFD0A0", Offset = "0xDFD0A0", VA = "0xDFD0A0")]
	private void InitView(bool needDisablePostEffect = false)
	{
	}

	[Token(Token = "0x6012946")]
	[Address(RVA = "0xDFDC9C", Offset = "0xDFDC9C", VA = "0xDFDC9C")]
	private void InitCamera()
	{
	}

	[Token(Token = "0x6012947")]
	[Address(RVA = "0xDFDD0C", Offset = "0xDFDD0C", VA = "0xDFDD0C")]
	private void SetCameraFovAccordingToResolution(Camera camera)
	{
	}

	[Token(Token = "0x6012948")]
	[Address(RVA = "0xDFDEDC", Offset = "0xDFDEDC", VA = "0xDFDEDC")]
	public void ClosePreview()
	{
	}

	[Token(Token = "0x6012949")]
	[Address(RVA = "0xDFF958", Offset = "0xDFF958", VA = "0xDFF958")]
	public void TempHidePreview(bool keepUIContent = false, bool keep3DContent = false)
	{
	}

	[Token(Token = "0x601294A")]
	[Address(RVA = "0xE00778", Offset = "0xE00778", VA = "0xE00778")]
	public void RecoverPreview(bool needShowCurrentPreview = true)
	{
	}

	[Token(Token = "0x601294B")]
	[Address(RVA = "0xE008B0", Offset = "0xE008B0", VA = "0xE008B0")]
	public void ShowCurrentPreview(bool isRecover)
	{
	}

	[Token(Token = "0x601294C")]
	[Address(RVA = "0xE02064", Offset = "0xE02064", VA = "0xE02064")]
	public bool IsCurrentPreviewAbReady()
	{
		return default(bool);
	}

	[Token(Token = "0x601294D")]
	[Address(RVA = "0xE02474", Offset = "0xE02474", VA = "0xE02474")]
	private void SetPreviewModelVisible(GameObject go, bool visible)
	{
	}

	[Token(Token = "0x601294E")]
	[Address(RVA = "0xE02590", Offset = "0xE02590", VA = "0xE02590")]
	public BoostState CheckBoostStateDelegate(uint itemID)
	{
		return default(BoostState);
	}

	[Token(Token = "0x601294F")]
	[Address(RVA = "0xE02B40", Offset = "0xE02B40", VA = "0xE02B40")]
	private uint SelectCustomAvatarID(bool isFemale)
	{
		return default(uint);
	}

	[Token(Token = "0x6012950")]
	[Address(RVA = "0xE02BAC", Offset = "0xE02BAC", VA = "0xE02BAC")]
	public UIPetAvatar GetPetAvatar()
	{
		return null;
	}

	[Token(Token = "0x6012951")]
	[Address(RVA = "0xE02C04", Offset = "0xE02C04", VA = "0xE02C04")]
	public void ForceRefreshShadow([Optional] UIMaleAvatar ava)
	{
	}

	[Token(Token = "0x6012952")]
	[Address(RVA = "0xE02F08", Offset = "0xE02F08", VA = "0xE02F08")]
	public void SetGroundShadowPos(Vector3 pos)
	{
	}

	[Token(Token = "0x6012953")]
	[Address(RVA = "0xE00A14", Offset = "0xE00A14", VA = "0xE00A14")]
	public void ShowPreviewByIdAccodingToLastParams(uint id, EInventory.AwardType award_type = EInventory.AwardType.AwardType_ITEM, bool isRecover = false)
	{
	}

	[Token(Token = "0x6012954")]
	[Address(RVA = "0xE03168", Offset = "0xE03168", VA = "0xE03168", Slot = "4")]
	public virtual void ShowPreviewById(uint id, EInventory.AwardType award_type = EInventory.AwardType.AwardType_ITEM, bool isShowDescription = true, bool isShowOwned = true, [Optional] FullScreenAnimParams animdata, bool showBundleScrollView = true, bool playAnimation = true, bool showBundleTitle = true, bool needResetAvatarDiretion = false, bool needShowInstallmentInfo = false, bool needResetUI = true, bool needRecordeParam = true, uint bundleIDIamIn = 0u, bool playLoopIdleSound = false, bool playPetLoopIdleSound = false)
	{
	}

	[Token(Token = "0x6012955")]
	[Address(RVA = "0xE09D24", Offset = "0xE09D24", VA = "0xE09D24")]
	private void InJectPreviewComponentToScript(GameObject go)
	{
	}

	[Token(Token = "0x6012956")]
	[Address(RVA = "0xE09EA0", Offset = "0xE09EA0", VA = "0xE09EA0")]
	public void FocusItemCameraBg()
	{
	}

	[Token(Token = "0x6012957")]
	[Address(RVA = "0xE09FC0", Offset = "0xE09FC0", VA = "0xE09FC0")]
	public void SetItemBgOnItemPreviewStateChange(bool zoom)
	{
	}

	[Token(Token = "0x6012958")]
	[Address(RVA = "0xE085E0", Offset = "0xE085E0", VA = "0xE085E0")]
	public void ShowItemByIdList(List<uint> idlist, bool special = false, ECollectionLevel level = ECollectionLevel.Lv3, bool isShow = true, bool showInstallmentInfo = false, bool playAnimation = true, bool needResetAvatarDiretion = false)
	{
	}

	[Token(Token = "0x6012959")]
	[Address(RVA = "0xE04DA0", Offset = "0xE04DA0", VA = "0xE04DA0")]
	private bool TryProcessBundleInsideItems(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x601295A")]
	[Address(RVA = "0xE0B0DC", Offset = "0xE0B0DC", VA = "0xE0B0DC")]
	private bool NeedShowHyperBookHiddenVFX(uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x601295B")]
	[Address(RVA = "0xE08BBC", Offset = "0xE08BBC", VA = "0xE08BBC")]
	private void ShowBoostAvatar(uint itemID, ShowBoostAvatarParams showBoostAvatarParams)
	{
	}

	[Token(Token = "0x601295C")]
	[Address(RVA = "0xE07E78", Offset = "0xE07E78", VA = "0xE07E78")]
	private void ShowPet(CSSharedItemData itemTemp, bool playPetLoopIdleSound = false)
	{
	}

	[Token(Token = "0x601295D")]
	[Address(RVA = "0xE0B830", Offset = "0xE0B830", VA = "0xE0B830")]
	private void ChangePreviewCameraEnable(PreviewCameraMove mixcameraComp, PreviewCameraMove avatarcameraComp, bool enabled)
	{
	}

	[Token(Token = "0x601295E")]
	[Address(RVA = "0xE0B8FC", Offset = "0xE0B8FC", VA = "0xE0B8FC")]
	public void StopAvatarAnim()
	{
	}

	[Token(Token = "0x601295F")]
	[Address(RVA = "0xE0BAD4", Offset = "0xE0BAD4", VA = "0xE0BAD4")]
	public UIMaleAvatar CreateAvatar(List<uint> idlist, Vector3 scale, Vector3 pos, bool playSpecial, bool changanim = true, int doubleAnimid = 0, string resSpecial = "", string resIdle = "", bool uselight = true, uint avatarIndex = 1u, bool playIdleAlternative = false)
	{
		return null;
	}

	[Token(Token = "0x6012960")]
	[Address(RVA = "0xE0C07C", Offset = "0xE0C07C", VA = "0xE0C07C")]
	public GameObject GetThreeDItemGameObj()
	{
		return null;
	}

	[Token(Token = "0x6012961")]
	[Address(RVA = "0xE0C0D4", Offset = "0xE0C0D4", VA = "0xE0C0D4")]
	public void ShowZoomItemById(uint id, bool needLight = false)
	{
	}

	[Token(Token = "0x6012962")]
	[Address(RVA = "0xE0D7E8", Offset = "0xE0D7E8", VA = "0xE0D7E8")]
	public void ShowZoomItemWithCameraById(uint id)
	{
	}

	[Token(Token = "0x6012963")]
	[Address(RVA = "0xE0D270", Offset = "0xE0D270", VA = "0xE0D270")]
	public void EnablePetRotate(bool enabled)
	{
	}

	[Token(Token = "0x6012964")]
	[Address(RVA = "0xE092EC", Offset = "0xE092EC", VA = "0xE092EC")]
	public void CheckAndPlayFacialAnim(CSSharedItemData data)
	{
	}

	[Token(Token = "0x6012965")]
	[Address(RVA = "0xE0E778", Offset = "0xE0E778", VA = "0xE0E778")]
	public Vector3 GetAutoShift3DPreviewpPos(ref GameObject go, float scalex, float scaley, bool useY)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6012966")]
	[Address(RVA = "0xE0F21C", Offset = "0xE0F21C", VA = "0xE0F21C")]
	public uint GetPreviewAvatarId(uint clothesID)
	{
		return default(uint);
	}

	[Token(Token = "0x6012967")]
	[Address(RVA = "0xE0F350", Offset = "0xE0F350", VA = "0xE0F350")]
	private uint GetPreviewAvatarId(AvatarWardrobeData wData, uint bundleShowFemale, uint bundleShowMale)
	{
		return default(uint);
	}

	[Token(Token = "0x6012968")]
	[Address(RVA = "0xE0F704", Offset = "0xE0F704", VA = "0xE0F704")]
	private uint GetPreviewAvatarId(uint bundleShowFemale, uint bundleShowMale)
	{
		return default(uint);
	}

	[Token(Token = "0x6012969")]
	[Address(RVA = "0xE0F7FC", Offset = "0xE0F7FC", VA = "0xE0F7FC", Slot = "5")]
	public virtual void Show3dHairStyleModel(uint hairid, int level = 3)
	{
	}

	[Token(Token = "0x601296A")]
	[Address(RVA = "0xE0A5B0", Offset = "0xE0A5B0", VA = "0xE0A5B0")]
	protected void ShowAvatarInternal(List<uint> idlist, AvatarType type = AvatarType.localAvatar, bool playanim = true, uint weaponID = 0u, uint petID = 0u)
	{
	}

	[Token(Token = "0x601296B")]
	[Address(RVA = "0xE00B7C", Offset = "0xE00B7C", VA = "0xE00B7C")]
	public void ShowAvatarByClothList(uint avatarID, List<uint> clothList, AvatarType type = AvatarType.localAvatar, bool playanim = true, uint weaponID = 0u, uint petID = 0u, bool needOptionalDownload = false, bool needClearUIData = true, [Optional] List<uint> checkOptionalIds)
	{
	}

	[Token(Token = "0x601296C")]
	[Address(RVA = "0xE0FF38", Offset = "0xE0FF38", VA = "0xE0FF38")]
	private void ShowAvatar(List<uint> idlist, AvatarType type = AvatarType.localAvatar, bool playanim = true, uint weaponID = 0u, uint petID = 0u, bool needOptionalDownload = false, bool isInternal = false, bool needClearUI = true, [Optional] List<uint> checkOptionalIds)
	{
	}

	[Token(Token = "0x601296D")]
	[Address(RVA = "0xE0DC14", Offset = "0xE0DC14", VA = "0xE0DC14")]
	private void ShowAvatarWithCurrentCloth(AvatarType type = AvatarType.localAvatar)
	{
	}

	[Token(Token = "0x601296E")]
	[Address(RVA = "0xE11614", Offset = "0xE11614", VA = "0xE11614")]
	private void PreviewDefaultClothes(List<uint> idlist, Cameratype type, UIMaleAvatar avatarmodel, bool playanim)
	{
	}

	[Token(Token = "0x601296F")]
	[Address(RVA = "0xDFF6B0", Offset = "0xDFF6B0", VA = "0xDFF6B0")]
	public void ClearCachedAvatar()
	{
	}

	[Token(Token = "0x6012970")]
	[Address(RVA = "0xE119D8", Offset = "0xE119D8", VA = "0xE119D8")]
	private void CreatePreviewAvatarWithNoCache(List<uint> idlist, bool playAnimation = true)
	{
	}

	[Token(Token = "0x6012971")]
	[Address(RVA = "0xE1245C", Offset = "0xE1245C", VA = "0xE1245C")]
	private void ForceAutoModifyAvatarPosOnPreviewBorderChange()
	{
	}

	[Token(Token = "0x6012972")]
	[Address(RVA = "0xE1288C", Offset = "0xE1288C", VA = "0xE1288C")]
	public void AutoModifyModelOnPreviewBorderChange()
	{
	}

	[Token(Token = "0x6012973")]
	[Address(RVA = "0xE11C00", Offset = "0xE11C00", VA = "0xE11C00")]
	private void CreatePreviewAvatarWithCache(List<uint> idlist)
	{
	}

	[Token(Token = "0x6012974")]
	[Address(RVA = "0xE13D4C", Offset = "0xE13D4C", VA = "0xE13D4C")]
	public void ShowEpicClothModel(uint clothID, int level)
	{
	}

	[Token(Token = "0x6012975")]
	[Address(RVA = "0xDFD6F4", Offset = "0xDFD6F4", VA = "0xDFD6F4")]
	private void SetCommonItemCameratrans(Vector3 trans, Quaternion rotate)
	{
	}

	[Token(Token = "0x6012976")]
	[Address(RVA = "0xE14164", Offset = "0xE14164", VA = "0xE14164", Slot = "6")]
	protected virtual void ShowPetAvatar(uint pet_id, uint readPetItemID, bool playPetLoopIdleSound = false)
	{
	}

	[Token(Token = "0x6012977")]
	[Address(RVA = "0xE15208", Offset = "0xE15208", VA = "0xE15208")]
	public void Set3dItemTouchEnable(bool flag)
	{
	}

	[Token(Token = "0x6012978")]
	[Address(RVA = "0xE0A670", Offset = "0xE0A670", VA = "0xE0A670")]
	private void Showitems(List<uint> idlist, bool isShow = true, ECollectionLevel level = ECollectionLevel.Lv3)
	{
	}

	[Token(Token = "0x6012979")]
	[Address(RVA = "0xE17004", Offset = "0xE17004", VA = "0xE17004")]
	public void SkipModelAnim()
	{
	}

	[Token(Token = "0x601297A")]
	[Address(RVA = "0xE15374", Offset = "0xE15374", VA = "0xE15374")]
	private void Show3DBootyBoxModel(uint id)
	{
	}

	[Token(Token = "0x601297B")]
	[Address(RVA = "0xE0D548", Offset = "0xE0D548", VA = "0xE0D548")]
	private GameObject LoadReview3dModel(ResourceID model_id)
	{
		return null;
	}

	[Token(Token = "0x601297C")]
	[Address(RVA = "0xE18024", Offset = "0xE18024", VA = "0xE18024")]
	private void Create360DegreePreview3dModel(ResourceID model_id, CollectionPreviewType type, uint weaponinfoid)
	{
	}

	[Token(Token = "0x601297D")]
	[Address(RVA = "0xE173E4", Offset = "0xE173E4", VA = "0xE173E4")]
	private void CreatePreview3dModel(ResourceID model_id, CollectionPreviewType type, uint weaponinfoid = 0u)
	{
	}

	[Token(Token = "0x601297E")]
	[Address(RVA = "0xE18F10", Offset = "0xE18F10", VA = "0xE18F10")]
	public void ShowAvatarSP(uint avatarid, bool playanim = true)
	{
	}

	[Token(Token = "0x601297F")]
	[Address(RVA = "0xE19280", Offset = "0xE19280", VA = "0xE19280")]
	public void ShowCachedAvatar(uint avatarid, bool playanim = false)
	{
	}

	[Token(Token = "0x6012980")]
	[Address(RVA = "0xE195F0", Offset = "0xE195F0", VA = "0xE195F0")]
	public void ShowCurrentBackpackModel(uint id)
	{
	}

	[Token(Token = "0x6012981")]
	[Address(RVA = "0xE0A1D8", Offset = "0xE0A1D8", VA = "0xE0A1D8")]
	public void Show3DJetpackModel(uint id, ECollectionLevel level)
	{
	}

	[Token(Token = "0x6012982")]
	[Address(RVA = "0xE15564", Offset = "0xE15564", VA = "0xE15564")]
	private void SHOW3DParachutecontainer(uint id)
	{
	}

	[Token(Token = "0x6012983")]
	[Address(RVA = "0xE16AA4", Offset = "0xE16AA4", VA = "0xE16AA4")]
	private void ShowHyperBook(uint id)
	{
	}

	[Token(Token = "0x6012984")]
	[Address(RVA = "0xE15748", Offset = "0xE15748", VA = "0xE15748")]
	private void SHOW3DSkyBoard(uint id)
	{
	}

	[Token(Token = "0x6012985")]
	[Address(RVA = "0xE1592C", Offset = "0xE1592C", VA = "0xE1592C")]
	private void SHOW3DFlight(uint id)
	{
	}

	[Token(Token = "0x6012986")]
	[Address(RVA = "0xE168C0", Offset = "0xE168C0", VA = "0xE168C0")]
	private void Show3DRedEnvelope(uint id)
	{
	}

	[Token(Token = "0x6012987")]
	[Address(RVA = "0xE199A0", Offset = "0xE199A0", VA = "0xE199A0")]
	public void ShowOnly3dWeapon(uint id)
	{
	}

	[Token(Token = "0x6012988")]
	[Address(RVA = "0xE160D8", Offset = "0xE160D8", VA = "0xE160D8")]
	private void SHOW3DWeaponSkin(uint id, WeaponSkinData lData)
	{
	}

	[Token(Token = "0x6012989")]
	[Address(RVA = "0xE19B88", Offset = "0xE19B88", VA = "0xE19B88")]
	private void RefreshWeaponPreviewUI(uint id, WeaponSkinData lData)
	{
	}

	[Token(Token = "0x601298A")]
	[Address(RVA = "0xE15B10", Offset = "0xE15B10", VA = "0xE15B10")]
	private void Show3DWeaponSkinWithAvatar(uint id, WeaponSkinData lData)
	{
	}

	[Token(Token = "0x601298B")]
	[Address(RVA = "0xE1662C", Offset = "0xE1662C", VA = "0xE1662C")]
	public void ShowEmoteWithCurrentAvatar(uint _eid, bool _special = false)
	{
	}

	[Token(Token = "0x601298C")]
	[Address(RVA = "0xE0DE9C", Offset = "0xE0DE9C", VA = "0xE0DE9C")]
	public void ShowGroupAnimWithCurrentAvatar(uint iId)
	{
	}

	[Token(Token = "0x601298D")]
	[Address(RVA = "0xE0E198", Offset = "0xE0E198", VA = "0xE0E198")]
	public void ShowTransformerWithCurrentAvatar(uint iId)
	{
	}

	[Token(Token = "0x601298E")]
	[Address(RVA = "0xE1AA80", Offset = "0xE1AA80", VA = "0xE1AA80")]
	public void PreviewGroupAnim(UIMaleAvatar avatar, uint iId, bool playIdleAlternate = false)
	{
	}

	[Token(Token = "0x601298F")]
	[Address(RVA = "0xE16414", Offset = "0xE16414", VA = "0xE16414")]
	protected void SHOW3DVehicleSkin(uint id)
	{
	}

	[Token(Token = "0x6012990")]
	[Address(RVA = "0xE1AD68", Offset = "0xE1AD68", VA = "0xE1AD68")]
	private void RefreshVehicleSkinPreviewUI(uint id)
	{
	}

	[Token(Token = "0x6012991")]
	[Address(RVA = "0xE0BE58", Offset = "0xE0BE58", VA = "0xE0BE58")]
	public void AutoModifyPreviewModelAccordingToResolution(ref GameObject go, bool calculateYPos = false, float scaley = 0.5f, bool isAvatar = false, bool calcaulateCenterPriviewAnchorPoint = true)
	{
	}

	[Token(Token = "0x6012992")]
	[Address(RVA = "0xE13248", Offset = "0xE13248", VA = "0xE13248")]
	protected void AutoModifyPreviewModelAccordingToResolution(ref GameObject go, GameObject boxGo, bool calculateYPos = false, float scaley = 0.5f, bool isAvatar = false, bool calcaulateCenterPriviewAnchorPoint = true)
	{
	}

	[Token(Token = "0x6012993")]
	[Address(RVA = "0xE13488", Offset = "0xE13488", VA = "0xE13488")]
	protected void AutoModifyPetModelAccordingToResolution(ref UIPetAvatar pet, bool calculateYPos = false, float scaley = 0.5f)
	{
	}

	[Token(Token = "0x6012994")]
	[Address(RVA = "0xE02DD4", Offset = "0xE02DD4", VA = "0xE02DD4")]
	public UIMaleAvatar GetCreateAvatar()
	{
		return null;
	}

	[Token(Token = "0x6012995")]
	[Address(RVA = "0xE1CF80", Offset = "0xE1CF80", VA = "0xE1CF80")]
	public UIMaleAvatar GetCachedAvatar()
	{
		return null;
	}

	[Token(Token = "0x6012996")]
	[Address(RVA = "0xE1D090", Offset = "0xE1D090", VA = "0xE1D090")]
	public void UpdatePreviewAvatarBackPack(uint id)
	{
	}

	[Token(Token = "0x6012997")]
	[Address(RVA = "0xE1D20C", Offset = "0xE1D20C", VA = "0xE1D20C")]
	private void CacheAvatarAnimtorSwitch(bool enabled)
	{
	}

	[Token(Token = "0x6012998")]
	[Address(RVA = "0xE1D388", Offset = "0xE1D388", VA = "0xE1D388")]
	public void ForceAutoModifyDoubleAvatarPos()
	{
	}

	[Token(Token = "0x6012999")]
	[Address(RVA = "0xE1D548", Offset = "0xE1D548", VA = "0xE1D548")]
	public void Clear3dModel()
	{
	}

	[Token(Token = "0x601299A")]
	[Address(RVA = "0xE1D668", Offset = "0xE1D668", VA = "0xE1D668")]
	public void SetPreviewAvatarLightVisble(bool flag)
	{
	}

	[Token(Token = "0x601299B")]
	[Address(RVA = "0xDFEB14", Offset = "0xDFEB14", VA = "0xDFEB14")]
	public void ClearCache(bool clearall = false, bool clearPreviewAvatar = true, bool clearPreviewCacheAvatar = false, bool clearDesc = false, bool clearUI = true)
	{
	}

	[Token(Token = "0x601299C")]
	[Address(RVA = "0xE10CC8", Offset = "0xE10CC8", VA = "0xE10CC8")]
	public void ClearCacheByAvatarType()
	{
	}

	[Token(Token = "0x601299D")]
	[Address(RVA = "0xE1DA8C", Offset = "0xE1DA8C", VA = "0xE1DA8C")]
	public void ClearCurrentPreviewType()
	{
	}

	[Token(Token = "0x601299E")]
	[Address(RVA = "0xE1DAE8", Offset = "0xE1DAE8", VA = "0xE1DAE8")]
	public void CreateDoublePreviewAvatar(PlayDoubleAvatarAnimParams param)
	{
	}

	[Token(Token = "0x601299F")]
	[Address(RVA = "0xE1E828", Offset = "0xE1E828", VA = "0xE1E828")]
	public void PlayDoubleAvatarAnim()
	{
	}

	[Token(Token = "0x60129A0")]
	[Address(RVA = "0xE1EA68", Offset = "0xE1EA68", VA = "0xE1EA68")]
	public void MarkDoubleSpecialAnim()
	{
	}

	[Token(Token = "0x60129A1")]
	[Address(RVA = "0xE1EB40", Offset = "0xE1EB40", VA = "0xE1EB40")]
	public void ForceAutoModifyDoubleAvatarPos(Vector3 left, Vector3 right)
	{
	}

	[Token(Token = "0x60129A2")]
	[Address(RVA = "0xE1ED2C", Offset = "0xE1ED2C", VA = "0xE1ED2C")]
	protected void AutoModifyPreviewModelAccordingToResolution(ref GameObject go, float scaley, Vector3 pos)
	{
	}

	[Token(Token = "0x60129A3")]
	[Address(RVA = "0xE1B628", Offset = "0xE1B628", VA = "0xE1B628")]
	private void AutoShift3DPreview(ref GameObject go, float scalex, float scaley, bool useY, bool calcaulateCenterPriviewAnchorPoint = true)
	{
	}

	[Token(Token = "0x60129A4")]
	[Address(RVA = "0xE1AE04", Offset = "0xE1AE04", VA = "0xE1AE04")]
	private void AutoGen3DPreviewCollider(GameObject go, bool isAvatar = false)
	{
	}

	[Token(Token = "0x60129A5")]
	[Address(RVA = "0xE1F320", Offset = "0xE1F320", VA = "0xE1F320")]
	private bool CheckInvaildCollider(Renderer render)
	{
		return default(bool);
	}

	[Token(Token = "0x60129A6")]
	[Address(RVA = "0xE1E500", Offset = "0xE1E500", VA = "0xE1E500")]
	private UIMaleAvatar CreatePreview2PAvatar(List<uint> idlist, Vector3 scale, Vector3 pos, Vector3 quater, int doubleAnimid, string specialAnimid, string idleAnimid, bool uselight, uint avatarIndex)
	{
		return null;
	}

	[Token(Token = "0x60129A7")]
	[Address(RVA = "0xE1F57C", Offset = "0xE1F57C", VA = "0xE1F57C")]
	public void SetDoubleCharcterRootScaleAndSkinVisble(uint avatarIndex)
	{
	}

	[Token(Token = "0x60129A8")]
	[Address(RVA = "0xE1F7BC", Offset = "0xE1F7BC", VA = "0xE1F7BC")]
	private Vector3 GetBoxColliderCenterPosition(BoxCollider boxcollider)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60129A9")]
	[Address(RVA = "0xE1F934", Offset = "0xE1F934", VA = "0xE1F934")]
	public void CreateDoubleWeapon(uint weapon1, uint weapon2, PlayDoubleWeaponParams param1, PlayDoubleWeaponParams param2)
	{
	}

	[Token(Token = "0x60129AA")]
	[Address(RVA = "0xE1FDBC", Offset = "0xE1FDBC", VA = "0xE1FDBC")]
	private void CreatePreviewWeaponListItem(uint weaponid, PlayDoubleWeaponParams param)
	{
	}

	[Token(Token = "0x60129AB")]
	[Address(RVA = "0xE204D4", Offset = "0xE204D4", VA = "0xE204D4")]
	public void CreatePreviewWeapon(uint weaponid, bool isShowWeaponNotification = true)
	{
	}

	[Token(Token = "0x60129AC")]
	[Address(RVA = "0xE20C40", Offset = "0xE20C40", VA = "0xE20C40")]
	public UIMaleAvatar CreatePreviewEmoteAvatar()
	{
		return null;
	}

	[Token(Token = "0x60129AD")]
	[Address(RVA = "0xE20F90", Offset = "0xE20F90", VA = "0xE20F90")]
	public void PreviewEmote(UIMaleAvatar avatar, uint emoteid, bool isSelect, bool loop = false, bool playIdleAlternate = false)
	{
	}

	[Token(Token = "0x60129AE")]
	[Address(RVA = "0xE21200", Offset = "0xE21200", VA = "0xE21200", Slot = "7")]
	public virtual void CreatePreviewAvatarWithBackpack(List<uint> idlist, uint collionid)
	{
	}

	[Token(Token = "0x60129AF")]
	[Address(RVA = "0xE19ED0", Offset = "0xE19ED0", VA = "0xE19ED0")]
	public void CreatePreviewAvatarWithWeapon(List<uint> idlist, uint weaponid)
	{
	}

	[Token(Token = "0x60129B0")]
	[Address(RVA = "0xE21A70", Offset = "0xE21A70", VA = "0xE21A70")]
	public void SetPreview3dItemEnabled(bool enabled)
	{
	}

	[Token(Token = "0x60129B1")]
	[Address(RVA = "0xE01230", Offset = "0xE01230", VA = "0xE01230")]
	public void CreatePreviewDoubleAvatarAnim(FullScreenAnimParams animParams, bool clearpool = true)
	{
	}

	[Token(Token = "0x60129B2")]
	[Address(RVA = "0xE0988C", Offset = "0xE0988C", VA = "0xE0988C")]
	private void ShowWebGuideBtn(uint id)
	{
	}

	[Token(Token = "0x60129B3")]
	[Address(RVA = "0xE21B78", Offset = "0xE21B78", VA = "0xE21B78")]
	public void CloseAllPreviewUI(bool isclear = false)
	{
	}

	[Token(Token = "0x60129B4")]
	[Address(RVA = "0xE21CEC", Offset = "0xE21CEC", VA = "0xE21CEC")]
	public void SetUIOnHyperBook()
	{
	}

	[Token(Token = "0x60129B5")]
	[Address(RVA = "0xE21DE8", Offset = "0xE21DE8", VA = "0xE21DE8")]
	public bool GetMagnifierState()
	{
		return default(bool);
	}

	[Token(Token = "0x60129B6")]
	[Address(RVA = "0xE21EE8", Offset = "0xE21EE8", VA = "0xE21EE8")]
	public void SetPreviewTweenEnabled(bool enabled)
	{
	}

	[Token(Token = "0x60129B7")]
	[Address(RVA = "0xE22200", Offset = "0xE22200", VA = "0xE22200")]
	public void DisableWeaponNotificationUI()
	{
	}

	[Token(Token = "0x60129B8")]
	[Address(RVA = "0xE2225C", Offset = "0xE2225C", VA = "0xE2225C")]
	public void CloseUIExceptMagn()
	{
	}

	[Token(Token = "0x60129B9")]
	[Address(RVA = "0xE07D7C", Offset = "0xE07D7C", VA = "0xE07D7C")]
	public void ClickDefaultBackPack()
	{
	}

	[Token(Token = "0x60129BA")]
	[Address(RVA = "0xE07818", Offset = "0xE07818", VA = "0xE07818")]
	public void ClickDefaultHairStyle()
	{
	}

	[Token(Token = "0x60129BB")]
	[Address(RVA = "0xE07914", Offset = "0xE07914", VA = "0xE07914")]
	public void ClickDefaultEpicClothStyle()
	{
	}

	[Token(Token = "0x60129BC")]
	[Address(RVA = "0xE002C8", Offset = "0xE002C8", VA = "0xE002C8")]
	public void ClearZoomInfo()
	{
	}

	[Token(Token = "0x60129BD")]
	[Address(RVA = "0xE068A0", Offset = "0xE068A0", VA = "0xE068A0")]
	private void Show2dIcon(uint id, bool needboost = false)
	{
	}

	[Token(Token = "0x60129BE")]
	[Address(RVA = "0xE0B324", Offset = "0xE0B324", VA = "0xE0B324")]
	public void ShowHyperBookHiddenPageVfx(uint itemID)
	{
	}

	[Token(Token = "0x60129BF")]
	[Address(RVA = "0xE22358", Offset = "0xE22358", VA = "0xE22358")]
	public void ShowSpecial2dIcon(AwardDesc awardItem, bool isShow = true, bool isBundle = false, bool refreshdesc = true)
	{
	}

	[Token(Token = "0x60129C0")]
	[Address(RVA = "0xE1D984", Offset = "0xE1D984", VA = "0xE1D984")]
	private void SetWeaponSkinUpgradeLevelVisble(bool isVisble)
	{
	}

	[Token(Token = "0x60129C1")]
	[Address(RVA = "0xE22AAC", Offset = "0xE22AAC", VA = "0xE22AAC")]
	public void SetBackPackVisble(bool isVisble)
	{
	}

	[Token(Token = "0x60129C2")]
	[Address(RVA = "0xE22BB4", Offset = "0xE22BB4", VA = "0xE22BB4")]
	public void SetHairStyleVisble(bool isVisble)
	{
	}

	[Token(Token = "0x60129C3")]
	[Address(RVA = "0xE22CBC", Offset = "0xE22CBC", VA = "0xE22CBC")]
	protected void SetEpicClothStyleVisble(bool isVisble)
	{
	}

	[Token(Token = "0x60129C4")]
	[Address(RVA = "0xE0B560", Offset = "0xE0B560", VA = "0xE0B560")]
	public void SetMagnifierVisble(bool isVisble)
	{
	}

	[Token(Token = "0x60129C5")]
	[Address(RVA = "0xE22DC4", Offset = "0xE22DC4", VA = "0xE22DC4")]
	public void Clear2dItem()
	{
	}

	[Token(Token = "0x60129C6")]
	[Address(RVA = "0xE22EE0", Offset = "0xE22EE0", VA = "0xE22EE0")]
	public void ShowPreview2DItem(bool show = true)
	{
	}

	[Token(Token = "0x60129C7")]
	[Address(RVA = "0xE22FE8", Offset = "0xE22FE8", VA = "0xE22FE8")]
	public void SetZoomBtnVisble(bool showzoomspr, bool showplayspr)
	{
	}

	[Token(Token = "0x60129C8")]
	[Address(RVA = "0xE23110", Offset = "0xE23110", VA = "0xE23110")]
	public void RefreshWeaponNotificationState()
	{
	}

	[Token(Token = "0x60129C9")]
	[Address(RVA = "0xE2321C", Offset = "0xE2321C", VA = "0xE2321C")]
	public void SetTreasureBoxProbabilityState(bool show, uint itemID)
	{
	}

	[Token(Token = "0x60129CA")]
	[Address(RVA = "0xE23364", Offset = "0xE23364", VA = "0xE23364")]
	public void ForceRefreshBundleEffectInfo(uint id)
	{
	}

	[Token(Token = "0x60129CB")]
	[Address(RVA = "0xE2369C", Offset = "0xE2369C", VA = "0xE2369C", Slot = "8")]
	protected virtual void SetSpecial2DIcon(BaseItemInfo itemInfo, string descText, bool isShowDescription)
	{
	}

	[Token(Token = "0x60129CC")]
	[Address(RVA = "0xE09994", Offset = "0xE09994", VA = "0xE09994")]
	private void SetBundleEffectInfo(List<BaseItemInfo> previewUIList)
	{
	}

	[Token(Token = "0x60129CD")]
	[Address(RVA = "0xE05FE8", Offset = "0xE05FE8", VA = "0xE05FE8")]
	private void SetBundleDescription(List<BaseItemInfo> previewUIList, int type, bool isShowOwned, bool showBundleScrollView = true, bool showTitle = true)
	{
	}

	[Token(Token = "0x60129CE")]
	[Address(RVA = "0xE05720", Offset = "0xE05720", VA = "0xE05720")]
	public void SetCommonDescription(uint id)
	{
	}

	[Token(Token = "0x60129CF")]
	[Address(RVA = "0xE237C8", Offset = "0xE237C8", VA = "0xE237C8")]
	public void RefreshSingleDesc(uint id)
	{
	}

	[Token(Token = "0x60129D0")]
	[Address(RVA = "0xE23A48", Offset = "0xE23A48", VA = "0xE23A48")]
	public void ShowIPTag()
	{
	}

	[Token(Token = "0x60129D1")]
	[Address(RVA = "0xE09784", Offset = "0xE09784", VA = "0xE09784")]
	public void ShowIPTag(uint id)
	{
	}

	[Token(Token = "0x60129D2")]
	[Address(RVA = "0xE09548", Offset = "0xE09548", VA = "0xE09548")]
	public void ShowInstallmentInfo(bool show, uint id)
	{
	}

	[Token(Token = "0x60129D3")]
	[Address(RVA = "0xE23B44", Offset = "0xE23B44", VA = "0xE23B44")]
	public void SetPreivewPanel(UIWidget previewBorder)
	{
	}

	[Token(Token = "0x60129D4")]
	[Address(RVA = "0xE23C68", Offset = "0xE23C68", VA = "0xE23C68")]
	public void SetAutoCalculatePanel(UIWidget previewBorder)
	{
	}

	[Token(Token = "0x60129D5")]
	[Address(RVA = "0xE0B1FC", Offset = "0xE0B1FC", VA = "0xE0B1FC")]
	public void SetHotFixDownload(bool isneeddownload, [Optional] DownloadInfoSpecific downloadInfo)
	{
	}

	[Token(Token = "0x60129D6")]
	[Address(RVA = "0xE23D70", Offset = "0xE23D70", VA = "0xE23D70")]
	public Vector2 GetDownLoadBtnWorldPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x60129D7")]
	[Address(RVA = "0xE23EB4", Offset = "0xE23EB4", VA = "0xE23EB4")]
	public Vector2 GetItemDescWorldPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x60129D8")]
	[Address(RVA = "0xE23FF8", Offset = "0xE23FF8", VA = "0xE23FF8")]
	public int RefreshPreviewPanelDepth(int baseDepth, bool includeSelf = true)
	{
		return default(int);
	}

	[Token(Token = "0x60129D9")]
	[Address(RVA = "0xE24274", Offset = "0xE24274", VA = "0xE24274")]
	public void SetCollecionBg(bool flag)
	{
	}

	[Token(Token = "0x60129DA")]
	[Address(RVA = "0xE2437C", Offset = "0xE2437C", VA = "0xE2437C")]
	public void EnableOptionalDownloadRefresh(bool enable)
	{
	}

	[Token(Token = "0x60129DB")]
	[Address(RVA = "0xE07BB8", Offset = "0xE07BB8", VA = "0xE07BB8")]
	private void ShowClothStyle(CSSharedItemData item)
	{
	}

	[Token(Token = "0x60129DC")]
	[Address(RVA = "0xE24478", Offset = "0xE24478", VA = "0xE24478")]
	private void ShowHairStyle(CSSharedItemData item)
	{
	}

	[Token(Token = "0x60129DD")]
	[Address(RVA = "0xE24660", Offset = "0xE24660", VA = "0xE24660")]
	private void ShowEpicClothStyle(CSSharedItemData item)
	{
	}

	[Token(Token = "0x60129DE")]
	[Address(RVA = "0xE246EC", Offset = "0xE246EC", VA = "0xE246EC")]
	private void ShowSpecAward(EInventory.AwardType awardtype, bool refreshDesc = true)
	{
	}

	[Token(Token = "0x60129DF")]
	[Address(RVA = "0xE09C0C", Offset = "0xE09C0C", VA = "0xE09C0C")]
	private void SetNeedDownloadState(bool needDownload)
	{
	}

	[Token(Token = "0x60129E0")]
	[Address(RVA = "0xE1EAE4", Offset = "0xE1EAE4", VA = "0xE1EAE4")]
	public void ClearMarkDoubleSpecialAnim()
	{
	}

	[Token(Token = "0x60129E1")]
	[Address(RVA = "0xE05618", Offset = "0xE05618", VA = "0xE05618")]
	public void RefreshCurrentId(uint itemid)
	{
	}

	[Token(Token = "0x60129E2")]
	[Address(RVA = "0xE24864", Offset = "0xE24864", VA = "0xE24864")]
	public void ClearResourceRefCache()
	{
	}

	[Token(Token = "0x60129E3")]
	[Address(RVA = "0xE18E70", Offset = "0xE18E70", VA = "0xE18E70")]
	private void ReadConfig(ref GameObject go, CollectionPreviewType collectiontype)
	{
	}

	[Token(Token = "0x60129E4")]
	[Address(RVA = "0xE248D0", Offset = "0xE248D0", VA = "0xE248D0")]
	private void ReadConfigFromPreview(ref GameObject go, int index, CollectionPreviewType collectiontype)
	{
	}

	[Token(Token = "0x60129E5")]
	[Address(RVA = "0xE249F4", Offset = "0xE249F4", VA = "0xE249F4")]
	private void SetPreviwConfig(ref GameObject go, FrontEndPreviewConfig.PreviewOneConifg configone, CollectionPreviewType collectiontype)
	{
	}

	[Token(Token = "0x60129E6")]
	[Address(RVA = "0xE24EFC", Offset = "0xE24EFC", VA = "0xE24EFC")]
	private void SetItemCameraFullViewPort()
	{
	}

	[Token(Token = "0x60129E7")]
	[Address(RVA = "0xDFD91C", Offset = "0xDFD91C", VA = "0xDFD91C")]
	private void SetItemCameraConfigViewPort()
	{
	}

	[Token(Token = "0x60129E8")]
	[Address(RVA = "0xE18BC0", Offset = "0xE18BC0", VA = "0xE18BC0")]
	private void SetMiamapBiasNear(GameObject go)
	{
	}

	[Token(Token = "0x60129E9")]
	[Address(RVA = "0xE0D1A0", Offset = "0xE0D1A0", VA = "0xE0D1A0")]
	private CollectionPreviewType GetWeaponType(WeaponSkinData data)
	{
		return default(CollectionPreviewType);
	}

	[Token(Token = "0x60129EA")]
	[Address(RVA = "0xE251B4", Offset = "0xE251B4", VA = "0xE251B4")]
	public bool CheckIsGrenadeWeapon(uint weaponid)
	{
		return default(bool);
	}

	[Token(Token = "0x60129EB")]
	[Address(RVA = "0xE25018", Offset = "0xE25018", VA = "0xE25018")]
	public bool CheckIsSmokeGrenadeWeapon(uint weaponid)
	{
		return default(bool);
	}

	[Token(Token = "0x60129EC")]
	[Address(RVA = "0xE25340", Offset = "0xE25340", VA = "0xE25340")]
	public bool CheckIsIceWallWeapon(uint weaponid)
	{
		return default(bool);
	}

	[Token(Token = "0x60129ED")]
	[Address(RVA = "0xE11DB0", Offset = "0xE11DB0", VA = "0xE11DB0")]
	public bool CheckIsDualWield(uint weaponid)
	{
		return default(bool);
	}

	[Token(Token = "0x60129EE")]
	[Address(RVA = "0xE11ECC", Offset = "0xE11ECC", VA = "0xE11ECC")]
	public List<uint> GetCurrentClothesList()
	{
		return null;
	}

	[Token(Token = "0x60129EF")]
	[Address(RVA = "0xDFF858", Offset = "0xDFF858", VA = "0xDFF858")]
	public void ClearItemData()
	{
	}

	[Token(Token = "0x60129F0")]
	[Address(RVA = "0xE06CCC", Offset = "0xE06CCC", VA = "0xE06CCC")]
	public void OnBoxItemBtnSelect(uint boxID, List<TreasureBoxShowData> boxList, out List<BaseItemInfo> previewUIList, out List<uint> preview3DList, out bool isSpecial)
	{
	}

	[Token(Token = "0x60129F1")]
	[Address(RVA = "0xE07A10", Offset = "0xE07A10", VA = "0xE07A10")]
	private void OnClothesItemSelect(uint clothesID, out List<uint> preview3DList, out bool isSpecial)
	{
	}

	[Token(Token = "0x60129F2")]
	[Address(RVA = "0xE0AFD4", Offset = "0xE0AFD4", VA = "0xE0AFD4")]
	private void SetInGameBonusID(uint itemId)
	{
	}

	[Token(Token = "0x60129F3")]
	[Address(RVA = "0xE05870", Offset = "0xE05870", VA = "0xE05870")]
	public void OnBundleItemSelect(uint bundleID, List<BundleShowData> bundleList, out List<BaseItemInfo> previewUIList, out List<uint> preview3DList, out bool isSpecial)
	{
	}

	[Token(Token = "0x60129F4")]
	[Address(RVA = "0xE0612C", Offset = "0xE0612C", VA = "0xE0612C")]
	public void OnOptionalBundleItemSelect(uint optionalBundleID, List<OptionalBundleShowData> optionalBundleList, out List<BaseItemInfo> previewUIList, out List<uint> preview3DList, out bool isSpecial)
	{
	}

	[Token(Token = "0x60129F5")]
	[Address(RVA = "0xE07554", Offset = "0xE07554", VA = "0xE07554")]
	public void OnHyperBookItemSelect(uint bookID, List<AwardDesc> bookAwardList, out List<BaseItemInfo> previewUIList, out List<uint> preview3DList)
	{
	}

	[Token(Token = "0x60129F6")]
	[Address(RVA = "0xE02810", Offset = "0xE02810", VA = "0xE02810")]
	public bool IsSpecialPreviewBundle(uint itemID, bool checkOwned = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60129F7")]
	[Address(RVA = "0xE25940", Offset = "0xE25940", VA = "0xE25940")]
	public bool IsSpecialPreviewBundle(List<BundleShowData> bundleList, bool checkOwned = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60129F8")]
	[Address(RVA = "0xE2636C", Offset = "0xE2636C", VA = "0xE2636C")]
	public bool IsSpecialPreviewOptionalBundle(uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x60129F9")]
	[Address(RVA = "0xE25EC0", Offset = "0xE25EC0", VA = "0xE25EC0")]
	public bool IsSpecialPreviewOptionalBundle(List<OptionalBundleShowData> optionalBundleList)
	{
		return default(bool);
	}

	[Token(Token = "0x60129FA")]
	[Address(RVA = "0xE029B0", Offset = "0xE029B0", VA = "0xE029B0")]
	public bool IsSpecialTreasureBox(uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x60129FB")]
	[Address(RVA = "0xE254CC", Offset = "0xE254CC", VA = "0xE254CC")]
	public bool IsSpecialTreasureBox(List<TreasureBoxShowData> boxList)
	{
		return default(bool);
	}

	[Token(Token = "0x60129FC")]
	[Address(RVA = "0xE264FC", Offset = "0xE264FC", VA = "0xE264FC")]
	public bool CheckCameraClick()
	{
		return default(bool);
	}

	[Token(Token = "0x60129FD")]
	[Address(RVA = "0xE266A0", Offset = "0xE266A0", VA = "0xE266A0")]
	public void ChangeCameraMove(bool isBoost)
	{
	}

	[Token(Token = "0x60129FE")]
	[Address(RVA = "0xE0B668", Offset = "0xE0B668", VA = "0xE0B668")]
	public PreviewCameraMove GetAvatarCameraComp()
	{
		return null;
	}

	[Token(Token = "0x60129FF")]
	[Address(RVA = "0xE26804", Offset = "0xE26804", VA = "0xE26804")]
	public void UseMixCamera()
	{
	}

	[Token(Token = "0x6012A00")]
	[Address(RVA = "0xDFE9A8", Offset = "0xDFE9A8", VA = "0xDFE9A8")]
	private void DestoryCamera()
	{
	}

	[Token(Token = "0x6012A01")]
	[Address(RVA = "0xE00610", Offset = "0xE00610", VA = "0xE00610")]
	private void ResetMixCameraRotation()
	{
	}

	[Token(Token = "0x6012A02")]
	[Address(RVA = "0xE2686C", Offset = "0xE2686C", VA = "0xE2686C")]
	public void ForceSetCameraType(Cameratype type)
	{
	}

	[Token(Token = "0x6012A03")]
	[Address(RVA = "0xE268CC", Offset = "0xE268CC", VA = "0xE268CC")]
	public void ForceSetItemTouchArea()
	{
	}

	[Token(Token = "0x6012A04")]
	[Address(RVA = "0xE269CC", Offset = "0xE269CC", VA = "0xE269CC")]
	public void RestorePreviewCamera()
	{
	}

	[Token(Token = "0x6012A05")]
	[Address(RVA = "0xE0FA3C", Offset = "0xE0FA3C", VA = "0xE0FA3C")]
	public void SwitchCamera(Cameratype type, bool isResume = false)
	{
	}

	[Token(Token = "0x6012A06")]
	[Address(RVA = "0xE0E464", Offset = "0xE0E464", VA = "0xE0E464")]
	public void CloseALLCamera()
	{
	}

	[Token(Token = "0x6012A07")]
	[Address(RVA = "0xE0D3FC", Offset = "0xE0D3FC", VA = "0xE0D3FC")]
	private void CloseMixCamera()
	{
	}

	[Token(Token = "0x6012A08")]
	[Address(RVA = "0xE26A34", Offset = "0xE26A34", VA = "0xE26A34")]
	public void ReStoreMixcamera()
	{
	}

	[Token(Token = "0x6012A09")]
	[Address(RVA = "0xDFE6DC", Offset = "0xDFE6DC", VA = "0xDFE6DC")]
	public void ResetCamera()
	{
	}

	[Token(Token = "0x6012A0A")]
	[Address(RVA = "0xE26B44", Offset = "0xE26B44", VA = "0xE26B44")]
	public void SkipSpecialAnim()
	{
	}

	[Token(Token = "0x6012A0B")]
	[Address(RVA = "0xE2754C", Offset = "0xE2754C", VA = "0xE2754C")]
	public void SetPreviewCgRotate(bool flag)
	{
	}

	[Token(Token = "0x6012A0C")]
	[Address(RVA = "0xE276C8", Offset = "0xE276C8", VA = "0xE276C8")]
	public void CreatePreviewVfxCg(ResourceID cgid)
	{
	}

	[Token(Token = "0x6012A0D")]
	[Address(RVA = "0xE2790C", Offset = "0xE2790C", VA = "0xE2790C")]
	public void CreatePreviewStoryCg(ResourceID cgid, uint uitype, bool isHas = false, bool showFuncBtn = true)
	{
	}

	[Token(Token = "0x6012A0E")]
	[Address(RVA = "0xE27CB8", Offset = "0xE27CB8", VA = "0xE27CB8")]
	public void CreatePreviewSkinAnim(uint uitype, ResourceID resid)
	{
	}

	[Token(Token = "0x6012A0F")]
	[Address(RVA = "0xE281F0", Offset = "0xE281F0", VA = "0xE281F0")]
	public bool GetCurrentCgSkip()
	{
		return default(bool);
	}

	[Token(Token = "0x6012A10")]
	[Address(RVA = "0xE27270", Offset = "0xE27270", VA = "0xE27270")]
	public void SkipStoryCg()
	{
	}

	[Token(Token = "0x6012A11")]
	[Address(RVA = "0xDFE590", Offset = "0xDFE590", VA = "0xDFE590")]
	public void ClosePreviewStoryCg()
	{
	}

	[Token(Token = "0x6012A12")]
	[Address(RVA = "0xE0043C", Offset = "0xE0043C", VA = "0xE0043C")]
	public void CloseCG()
	{
	}

	[Token(Token = "0x6012A13")]
	[Address(RVA = "0xE283FC", Offset = "0xE283FC", VA = "0xE283FC")]
	public void CGCameraChange()
	{
	}

	[Token(Token = "0x6012A14")]
	[Address(RVA = "0xE28394", Offset = "0xE28394", VA = "0xE28394")]
	public void CGCameraResume()
	{
	}

	[Token(Token = "0x6012A15")]
	[Address(RVA = "0xE286D4", Offset = "0xE286D4", VA = "0xE286D4")]
	public void SetCGVisible(bool flag)
	{
	}

	[Token(Token = "0x6012A16")]
	[Address(RVA = "0xE287DC", Offset = "0xE287DC", VA = "0xE287DC")]
	public bool HasCG()
	{
		return default(bool);
	}

	[Token(Token = "0x6012A17")]
	[Address(RVA = "0xE288B0", Offset = "0xE288B0", VA = "0xE288B0")]
	public void SetCGLightVisible(bool visible)
	{
	}

	[Token(Token = "0x6012A18")]
	[Address(RVA = "0xE28B64", Offset = "0xE28B64", VA = "0xE28B64")]
	public void ReplayCg()
	{
	}

	[Token(Token = "0x6012A19")]
	[Address(RVA = "0xE28EF0", Offset = "0xE28EF0", VA = "0xE28EF0")]
	public void RrefreshWeaponTimeLine()
	{
	}

	[Token(Token = "0x6012A1A")]
	[Address(RVA = "0xE29100", Offset = "0xE29100", VA = "0xE29100")]
	public float GetCurCGTimeStamp()
	{
		return default(float);
	}

	[Token(Token = "0x6012A1B")]
	[Address(RVA = "0xE29468", Offset = "0xE29468", VA = "0xE29468")]
	public GameObject Test_GetMixCameraGo()
	{
		return null;
	}

	[Token(Token = "0x6012A1C")]
	[Address(RVA = "0xE294C0", Offset = "0xE294C0", VA = "0xE294C0")]
	public void Test_HideAllCamera()
	{
	}

	[Token(Token = "0x6012A1D")]
	[Address(RVA = "0xE29698", Offset = "0xE29698", VA = "0xE29698")]
	private static BoostState _003CShowEpicClothModel_003Em__0(uint id)
	{
		return default(BoostState);
	}
}
