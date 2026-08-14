using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200268E")]
internal class UIGachaFeatureController : UIPopupWindowController
{
	[Token(Token = "0x200268F")]
	private class ModelTransformerAttri
	{
		[Token(Token = "0x400EDFB")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 m_Pos;

		[Token(Token = "0x400EDFC")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 m_Rot;

		[Token(Token = "0x400EDFD")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 m_Scale;

		[Token(Token = "0x600E7D3")]
		[Address(RVA = "0x2487BD4", Offset = "0x2487BD4", VA = "0x2487BD4")]
		public ModelTransformerAttri(Vector3 pos, Vector3 rot, Vector3 scale)
		{
		}
	}

	[Token(Token = "0x2002690")]
	private sealed class _003CIEChangeBtnLayer_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400EDFE")]
		[FieldOffset(Offset = "0x8")]
		internal UIGachaFeatureController _0024this;

		[Token(Token = "0x400EDFF")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400EE00")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400EE01")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17001191")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600E7D6")]
			[Address(RVA = "0x2487F78", Offset = "0x2487F78", VA = "0x2487F78", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001192")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600E7D7")]
			[Address(RVA = "0x2487F80", Offset = "0x2487F80", VA = "0x2487F80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600E7D4")]
		[Address(RVA = "0x24861F8", Offset = "0x24861F8", VA = "0x24861F8")]
		public _003CIEChangeBtnLayer_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600E7D5")]
		[Address(RVA = "0x2487D28", Offset = "0x2487D28", VA = "0x2487D28", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600E7D8")]
		[Address(RVA = "0x2487F88", Offset = "0x2487F88", VA = "0x2487F88", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600E7D9")]
		[Address(RVA = "0x2487F9C", Offset = "0x2487F9C", VA = "0x2487F9C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400EDE9")]
	[FieldOffset(Offset = "0x0")]
	public static bool IsOpen;

	[Token(Token = "0x400EDEA")]
	[FieldOffset(Offset = "0x48")]
	private UIGachaFeatureView m_View;

	[Token(Token = "0x400EDEB")]
	[FieldOffset(Offset = "0x4C")]
	private GameObject m_FeatureModel;

	[Token(Token = "0x400EDEC")]
	[FieldOffset(Offset = "0x50")]
	private Transform m_FeatureSubTrans;

	[Token(Token = "0x400EDED")]
	[FieldOffset(Offset = "0x54")]
	private UIMaleAvatar m_FeatureAvatar;

	[Token(Token = "0x400EDEE")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_FeatureCamera;

	[Token(Token = "0x400EDEF")]
	[FieldOffset(Offset = "0x5C")]
	private GameObject m_GroundShadow;

	[Token(Token = "0x400EDF0")]
	[FieldOffset(Offset = "0x60")]
	private CSSharedItemData m_Data;

	[Token(Token = "0x400EDF1")]
	private const float m_RotateRate = 0.5f;

	[Token(Token = "0x400EDF2")]
	[FieldOffset(Offset = "0x64")]
	private bool m_NeedRotate;

	[Token(Token = "0x400EDF3")]
	[FieldOffset(Offset = "0x65")]
	private bool m_WeaponCGCanRotate;

	[Token(Token = "0x400EDF4")]
	[FieldOffset(Offset = "0x68")]
	private UI2dCommonController m_2dPreviewitem;

	[Token(Token = "0x400EDF5")]
	[FieldOffset(Offset = "0x6C")]
	private Texture2D m_BgTerxture;

	[Token(Token = "0x400EDF6")]
	[FieldOffset(Offset = "0x70")]
	private ItemUtil.ItemShareType m_ShareType;

	[Token(Token = "0x400EDF7")]
	[FieldOffset(Offset = "0x74")]
	private UIAvatarLinkShareInfoController m_AvatarLinkCon;

	[Token(Token = "0x400EDF8")]
	[FieldOffset(Offset = "0x78")]
	private FrontEndPreviewComponent m_FrontEndPreviewComponent;

	[Token(Token = "0x400EDF9")]
	[FieldOffset(Offset = "0x4")]
	private static readonly Dictionary<int, ModelTransformerAttri> m_TransAttriDict;

	[Token(Token = "0x400EDFA")]
	[FieldOffset(Offset = "0x7C")]
	public Action m_CloseAction;

	[Token(Token = "0x600E78E")]
	[Address(RVA = "0x247C038", Offset = "0x247C038", VA = "0x247C038")]
	public UIGachaFeatureController()
	{
	}

	[Token(Token = "0x600E78F")]
	[Address(RVA = "0x247C048", Offset = "0x247C048", VA = "0x247C048")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E790")]
	[Address(RVA = "0x247C0EC", Offset = "0x247C0EC", VA = "0x247C0EC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E791")]
	[Address(RVA = "0x247C860", Offset = "0x247C860", VA = "0x247C860")]
	public void ShowFeatureView(uint itemID, ItemUtil.ItemShareType shareType)
	{
	}

	[Token(Token = "0x600E792")]
	[Address(RVA = "0x247D9DC", Offset = "0x247D9DC", VA = "0x247D9DC")]
	private void CreateFeature()
	{
	}

	[Token(Token = "0x600E793")]
	[Address(RVA = "0x247EC54", Offset = "0x247EC54", VA = "0x247EC54")]
	private void UpdateSkinMeshRender(bool flag)
	{
	}

	[Token(Token = "0x600E794")]
	[Address(RVA = "0x247EEC8", Offset = "0x247EEC8", VA = "0x247EEC8")]
	private void WeaponCgStart(object[] data)
	{
	}

	[Token(Token = "0x600E795")]
	[Address(RVA = "0x247EFAC", Offset = "0x247EFAC", VA = "0x247EFAC")]
	private void WeaponCgEnd(object[] data)
	{
	}

	[Token(Token = "0x600E796")]
	[Address(RVA = "0x247F090", Offset = "0x247F090", VA = "0x247F090")]
	private void WeaponRotateChange(object[] data)
	{
	}

	[Token(Token = "0x600E797")]
	[Address(RVA = "0x247F1AC", Offset = "0x247F1AC", VA = "0x247F1AC")]
	private void OnShowFeature(object[] data)
	{
	}

	[Token(Token = "0x600E798")]
	[Address(RVA = "0x247F9D0", Offset = "0x247F9D0", VA = "0x247F9D0")]
	private void TryShowLuckyWheelShareInfo()
	{
	}

	[Token(Token = "0x600E799")]
	[Address(RVA = "0x247CB38", Offset = "0x247CB38", VA = "0x247CB38")]
	private void EnableUI(bool v)
	{
	}

	[Token(Token = "0x600E79A")]
	[Address(RVA = "0x248088C", Offset = "0x248088C", VA = "0x248088C")]
	public void SetFeatureCameraDepth(float depth)
	{
	}

	[Token(Token = "0x600E79B")]
	[Address(RVA = "0x2480A08", Offset = "0x2480A08", VA = "0x2480A08")]
	public void Set3DModelVisiable(bool b)
	{
	}

	[Token(Token = "0x600E79C")]
	[Address(RVA = "0x247DC10", Offset = "0x247DC10", VA = "0x247DC10")]
	private void CreateCamera()
	{
	}

	[Token(Token = "0x600E79D")]
	[Address(RVA = "0x2480B30", Offset = "0x2480B30", VA = "0x2480B30")]
	private ResourceID ItemID2ResID(uint itemID)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E79E")]
	[Address(RVA = "0x2481268", Offset = "0x2481268", VA = "0x2481268")]
	private bool Is2DCollectionItem()
	{
		return default(bool);
	}

	[Token(Token = "0x600E79F")]
	[Address(RVA = "0x247DFEC", Offset = "0x247DFEC", VA = "0x247DFEC")]
	private void CreateFetureItem()
	{
	}

	[Token(Token = "0x600E7A0")]
	[Address(RVA = "0x248144C", Offset = "0x248144C", VA = "0x248144C")]
	private bool IsCollectionFist(CSSharedItemData data)
	{
		return default(bool);
	}

	[Token(Token = "0x600E7A1")]
	[Address(RVA = "0x2481300", Offset = "0x2481300", VA = "0x2481300")]
	private bool CheckItemABReady(uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x600E7A2")]
	[Address(RVA = "0x247EA1C", Offset = "0x247EA1C", VA = "0x247EA1C")]
	private void CreateBundle()
	{
	}

	[Token(Token = "0x600E7A3")]
	[Address(RVA = "0x24823E0", Offset = "0x24823E0", VA = "0x24823E0")]
	private void CreatePetAvatar(uint itemID)
	{
	}

	[Token(Token = "0x600E7A4")]
	[Address(RVA = "0x2482F1C", Offset = "0x2482F1C", VA = "0x2482F1C")]
	private void CreateRigidbody(ResourceID resID)
	{
	}

	[Token(Token = "0x600E7A5")]
	[Address(RVA = "0x2482D70", Offset = "0x2482D70", VA = "0x2482D70")]
	private void CreatHyperBook(uint itemID)
	{
	}

	[Token(Token = "0x600E7A6")]
	[Address(RVA = "0x24815E8", Offset = "0x24815E8", VA = "0x24815E8")]
	private void CreateAvatar(uint itemID)
	{
	}

	[Token(Token = "0x600E7A7")]
	[Address(RVA = "0x2482000", Offset = "0x2482000", VA = "0x2482000")]
	private void CreateEmoteAvatar()
	{
	}

	[Token(Token = "0x600E7A8")]
	[Address(RVA = "0x2482158", Offset = "0x2482158", VA = "0x2482158")]
	private void CreateGroupAnimAvatar()
	{
	}

	[Token(Token = "0x600E7A9")]
	[Address(RVA = "0x24822A4", Offset = "0x24822A4", VA = "0x24822A4")]
	private void CreateTransformerAvatar()
	{
	}

	[Token(Token = "0x600E7AA")]
	[Address(RVA = "0x2483148", Offset = "0x2483148", VA = "0x2483148")]
	private UIMaleAvatar CreatePreviewEmoteAvatar()
	{
		return null;
	}

	[Token(Token = "0x600E7AB")]
	[Address(RVA = "0x248349C", Offset = "0x248349C", VA = "0x248349C")]
	public void PreviewEmote(UIMaleAvatar avatar, uint emoteid, bool isSelect, bool loop = false, bool playIdleAlternate = false)
	{
	}

	[Token(Token = "0x600E7AC")]
	[Address(RVA = "0x24836BC", Offset = "0x24836BC", VA = "0x24836BC")]
	public void PreviewGroupAnim(UIMaleAvatar avatar, uint iId, bool playIdleAlternate = false)
	{
	}

	[Token(Token = "0x600E7AD")]
	[Address(RVA = "0x2483954", Offset = "0x2483954", VA = "0x2483954")]
	public void PreviewTransformer(UIMaleAvatar avatar, uint iId)
	{
	}

	[Token(Token = "0x600E7AE")]
	[Address(RVA = "0x247FCBC", Offset = "0x247FCBC", VA = "0x247FCBC")]
	private void Adjust3DModel(Dictionary<int, ModelTransformerAttri> transAttriDict)
	{
	}

	[Token(Token = "0x600E7AF")]
	[Address(RVA = "0x247D69C", Offset = "0x247D69C", VA = "0x247D69C")]
	private void SetDoNeedRotate()
	{
	}

	[Token(Token = "0x600E7B0")]
	[Address(RVA = "0x2483BC8", Offset = "0x2483BC8", VA = "0x2483BC8")]
	private Transform GetSubTransfrom()
	{
		return null;
	}

	[Token(Token = "0x600E7B1")]
	[Address(RVA = "0x2483CF8", Offset = "0x2483CF8", VA = "0x2483CF8")]
	private void Rotate3DModel()
	{
	}

	[Token(Token = "0x600E7B2")]
	[Address(RVA = "0x2484190", Offset = "0x2484190", VA = "0x2484190")]
	private void Update()
	{
	}

	[Token(Token = "0x600E7B3")]
	[Address(RVA = "0x2484200", Offset = "0x2484200", VA = "0x2484200")]
	private void OnOKBtnClick()
	{
	}

	[Token(Token = "0x600E7B4")]
	[Address(RVA = "0x2484264", Offset = "0x2484264", VA = "0x2484264")]
	private void OnShareBtnClik()
	{
	}

	[Token(Token = "0x600E7B5")]
	[Address(RVA = "0x24849F4", Offset = "0x24849F4", VA = "0x24849F4")]
	private void OnScreenShotClose()
	{
	}

	[Token(Token = "0x600E7B6")]
	[Address(RVA = "0x2484B1C", Offset = "0x2484B1C", VA = "0x2484B1C")]
	private void ShowAvatarLinkShareInfo(bool flag)
	{
	}

	[Token(Token = "0x600E7B7")]
	[Address(RVA = "0x2484E64", Offset = "0x2484E64", VA = "0x2484E64", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x600E7B8")]
	[Address(RVA = "0x2485100", Offset = "0x2485100", VA = "0x2485100", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x600E7B9")]
	[Address(RVA = "0x2484EDC", Offset = "0x2484EDC", VA = "0x2484EDC")]
	private void SetAvatarKLinkShareBefore()
	{
	}

	[Token(Token = "0x600E7BA")]
	[Address(RVA = "0x2485178", Offset = "0x2485178", VA = "0x2485178")]
	private void SetAvatarKLinkShareAfter()
	{
	}

	[Token(Token = "0x600E7BB")]
	[Address(RVA = "0x2485460", Offset = "0x2485460", VA = "0x2485460")]
	private void SetAvatarLinkContentShareBefore()
	{
	}

	[Token(Token = "0x600E7BC")]
	[Address(RVA = "0x247CBF0", Offset = "0x247CBF0", VA = "0x247CBF0")]
	private void SetShareUIVisiable(bool isScreenShot)
	{
	}

	[Token(Token = "0x600E7BD")]
	[Address(RVA = "0x2485594", Offset = "0x2485594", VA = "0x2485594", Slot = "43")]
	public override void OnPopupWindowListChange()
	{
	}

	[Token(Token = "0x600E7BE")]
	[Address(RVA = "0x24811D0", Offset = "0x24811D0", VA = "0x24811D0")]
	private void SetTouchEnable(bool b)
	{
	}

	[Token(Token = "0x600E7BF")]
	[Address(RVA = "0x247D55C", Offset = "0x247D55C", VA = "0x247D55C")]
	private void AdjustBGScale()
	{
	}

	[Token(Token = "0x600E7C0")]
	[Address(RVA = "0x247D074", Offset = "0x247D074", VA = "0x247D074")]
	private void UpdateViewInfo()
	{
	}

	[Token(Token = "0x600E7C1")]
	[Address(RVA = "0x2485A7C", Offset = "0x2485A7C", VA = "0x2485A7C")]
	private void OnMaskClick()
	{
	}

	[Token(Token = "0x600E7C2")]
	[Address(RVA = "0x2485610", Offset = "0x2485610", VA = "0x2485610")]
	public void ShowIPTag()
	{
	}

	[Token(Token = "0x600E7C3")]
	[Address(RVA = "0x248460C", Offset = "0x248460C", VA = "0x248460C")]
	private void ChangeLayer(Transform trans, string targetLayer)
	{
	}

	[Token(Token = "0x600E7C4")]
	[Address(RVA = "0x247DF98", Offset = "0x247DF98", VA = "0x247DF98")]
	private void PlayPopWndSound()
	{
	}

	[Token(Token = "0x600E7C5")]
	[Address(RVA = "0x2485CB8", Offset = "0x2485CB8", VA = "0x2485CB8")]
	private void Destroy3DModel()
	{
	}

	[Token(Token = "0x600E7C6")]
	[Address(RVA = "0x2485E6C", Offset = "0x2485E6C", VA = "0x2485E6C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E7C7")]
	[Address(RVA = "0x2485FD8", Offset = "0x2485FD8", VA = "0x2485FD8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E7C8")]
	[Address(RVA = "0x247CDAC", Offset = "0x247CDAC", VA = "0x247CDAC")]
	private void CreateShadow()
	{
	}

	[Token(Token = "0x600E7C9")]
	[Address(RVA = "0x247C794", Offset = "0x247C794", VA = "0x247C794")]
	private IEnumerator IEChangeBtnLayer()
	{
		return null;
	}

	[Token(Token = "0x600E7CA")]
	[Address(RVA = "0x248039C", Offset = "0x248039C", VA = "0x248039C")]
	private void TryPushCamera()
	{
	}

	[Token(Token = "0x600E7CB")]
	[Address(RVA = "0x2486200", Offset = "0x2486200", VA = "0x2486200")]
	private BoostState CheckBoostStateDelegate(uint itemID)
	{
		return default(BoostState);
	}

	[Token(Token = "0x600E7CD")]
	[Address(RVA = "0x2487CF8", Offset = "0x2487CF8", VA = "0x2487CF8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E7CE")]
	[Address(RVA = "0x2487D00", Offset = "0x2487D00", VA = "0x2487D00")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x600E7CF")]
	[Address(RVA = "0x2487D08", Offset = "0x2487D08", VA = "0x2487D08")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	[Token(Token = "0x600E7D0")]
	[Address(RVA = "0x2487D10", Offset = "0x2487D10", VA = "0x2487D10")]
	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}

	[Token(Token = "0x600E7D1")]
	[Address(RVA = "0x2487D18", Offset = "0x2487D18", VA = "0x2487D18")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E7D2")]
	[Address(RVA = "0x2487D20", Offset = "0x2487D20", VA = "0x2487D20")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
