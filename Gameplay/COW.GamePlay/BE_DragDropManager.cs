using System;
using System.Collections.Generic;
using COW.Gameplay.UGC.BlockEdit;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000BFE")]
public class BE_DragDropManager : MonoBehaviour
{
	[Token(Token = "0x2000BFF")]
	private sealed class LHFGCIODNKO
	{
		[Token(Token = "0x4006377")]
		[FieldOffset(Offset = "0x8")]
		internal bool FNNLNOOIBMJ;

		[Token(Token = "0x4006378")]
		[FieldOffset(Offset = "0xC")]
		internal string MCJNDAJBBJL;

		[Token(Token = "0x4006379")]
		[FieldOffset(Offset = "0x10")]
		internal BE_DragDropManager GADHAMJEKIM;

		[Token(Token = "0x6005AF1")]
		[Address(RVA = "0x2D425FC", Offset = "0x2D425FC", VA = "0x2D425FC")]
		public LHFGCIODNKO()
		{
		}

		[Token(Token = "0x6005AF2")]
		[Address(RVA = "0x2D44C5C", Offset = "0x2D44C5C", VA = "0x2D44C5C")]
		internal void CHOPCLCOBKC()
		{
		}

		[Token(Token = "0x6005AF3")]
		[Address(RVA = "0x2D45044", Offset = "0x2D45044", VA = "0x2D45044")]
		internal void HJGBDJENEAM()
		{
		}
	}

	[Token(Token = "0x400635D")]
	[FieldOffset(Offset = "0xC")]
	public bool IsDragging;

	[Token(Token = "0x400635E")]
	[FieldOffset(Offset = "0x10")]
	private BE_DragDropItem _003CCPFHIMPNPDL_003Ek__BackingField;

	[Token(Token = "0x400635F")]
	[FieldOffset(Offset = "0x14")]
	public UISprite HorizHighLightSprite;

	[Token(Token = "0x4006360")]
	[FieldOffset(Offset = "0x18")]
	public UISprite VerticalHighLightSprite;

	[Token(Token = "0x4006361")]
	[FieldOffset(Offset = "0x1C")]
	private HashSet<BE_BlockSpot> IBCELEKCEIP;

	[Token(Token = "0x4006362")]
	[FieldOffset(Offset = "0x20")]
	private HashSet<BCEILEJONNO> MDHNPKICBIA;

	[Token(Token = "0x4006363")]
	[FieldOffset(Offset = "0x24")]
	private HashSet<EKEOCIDDIFH> CJCJEAMNLDM;

	[Token(Token = "0x4006364")]
	[FieldOffset(Offset = "0x0")]
	public static int BE_MAXDEPTHDEF;

	[Token(Token = "0x4006365")]
	[FieldOffset(Offset = "0x28")]
	private HashSet<BE_SlotSpot> JKENKKMACEP;

	[Token(Token = "0x4006366")]
	[FieldOffset(Offset = "0x2C")]
	private HashSet<string> NPDLEPANDNB;

	[Token(Token = "0x4006367")]
	[FieldOffset(Offset = "0x30")]
	public int MaxDepth;

	[Token(Token = "0x4006368")]
	[FieldOffset(Offset = "0x34")]
	public UIButton CopyBtn;

	[Token(Token = "0x4006369")]
	[FieldOffset(Offset = "0x38")]
	public UIButton PasteBtn;

	[Token(Token = "0x400636A")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton ClearButton;

	[Token(Token = "0x400636B")]
	[FieldOffset(Offset = "0x40")]
	public UIButton UndoBtn;

	[Token(Token = "0x400636C")]
	[FieldOffset(Offset = "0x44")]
	public UIButton RedoBtn;

	[Token(Token = "0x400636D")]
	[FieldOffset(Offset = "0x48")]
	public float DetectionSpotDistance;

	[Token(Token = "0x400636E")]
	[FieldOffset(Offset = "0x4C")]
	private MICEMKOOFOF _003CMDHNKIGKCFI_003Ek__BackingField;

	[Token(Token = "0x400636F")]
	[FieldOffset(Offset = "0x50")]
	public BCEILEJONNO m_LastHighLightSection;

	[Token(Token = "0x4006370")]
	[FieldOffset(Offset = "0x54")]
	public EKEOCIDDIFH m_LastHighLightDataBlock;

	[Token(Token = "0x4006371")]
	[FieldOffset(Offset = "0x58")]
	public BE_BlockSectionHeader_LocalVarDefine m_LastLocalVar;

	[Token(Token = "0x4006372")]
	[FieldOffset(Offset = "0x5C")]
	private UIClickMask NDCABADGHMP;

	[Token(Token = "0x4006373")]
	[FieldOffset(Offset = "0x4")]
	public static readonly Dictionary<string, LocalVarDefineData> LocalVarDefineCache;

	[Token(Token = "0x4006374")]
	[FieldOffset(Offset = "0x60")]
	private BCHGEIGDHIC MDKOJIPODKI;

	[Token(Token = "0x4006375")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<BCEILEJONNO> HMDOHFBHDOB;

	[Token(Token = "0x4006376")]
	[FieldOffset(Offset = "0xC")]
	private static Comparison<EKEOCIDDIFH> AOCDJNOINOH;

	[Token(Token = "0x17000778")]
	public BE_DragDropItem AFMJNAKEDHF
	{
		[Token(Token = "0x6005AB4")]
		[Address(RVA = "0x2D3DD2C", Offset = "0x2D3DD2C", VA = "0x2D3DD2C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005AB5")]
		[Address(RVA = "0x2D3DD34", Offset = "0x2D3DD34", VA = "0x2D3DD34")]
		set
		{
		}
	}

	[Token(Token = "0x17000779")]
	public HashSet<BCEILEJONNO> PBNFOPGAJMC
	{
		[Token(Token = "0x6005AB6")]
		[Address(RVA = "0x2D37FA4", Offset = "0x2D37FA4", VA = "0x2D37FA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700077A")]
	public HashSet<EKEOCIDDIFH> CAOMGHIGCPP
	{
		[Token(Token = "0x6005AB7")]
		[Address(RVA = "0x2D26284", Offset = "0x2D26284", VA = "0x2D26284")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700077B")]
	public MICEMKOOFOF OBEOGGGNIMO
	{
		[Token(Token = "0x6005AB8")]
		[Address(RVA = "0x2D3DD3C", Offset = "0x2D3DD3C", VA = "0x2D3DD3C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005AB9")]
		[Address(RVA = "0x2D3DD44", Offset = "0x2D3DD44", VA = "0x2D3DD44")]
		set
		{
		}
	}

	[Token(Token = "0x6005AB3")]
	[Address(RVA = "0x2D3DBC4", Offset = "0x2D3DBC4", VA = "0x2D3DBC4")]
	public BE_DragDropManager()
	{
	}

	[Token(Token = "0x6005ABA")]
	[Address(RVA = "0x2D3DD4C", Offset = "0x2D3DD4C", VA = "0x2D3DD4C")]
	private void Start()
	{
	}

	[Token(Token = "0x6005ABB")]
	[Address(RVA = "0x2D353C4", Offset = "0x2D353C4", VA = "0x2D353C4")]
	public void OnDragStart(BE_DragDropItem KLIPIFJMGNE)
	{
	}

	[Token(Token = "0x6005ABC")]
	[Address(RVA = "0x2D2D3E0", Offset = "0x2D2D3E0", VA = "0x2D2D3E0")]
	public void OnDragEnd()
	{
	}

	[Token(Token = "0x6005ABD")]
	[Address(RVA = "0x2D3E160", Offset = "0x2D3E160", VA = "0x2D3E160")]
	public void OnApplicationFocus(bool ADCPNPBKPKP)
	{
	}

	[Token(Token = "0x6005ABE")]
	[Address(RVA = "0x2D3E278", Offset = "0x2D3E278", VA = "0x2D3E278")]
	public void AddLimitBlock(string CJMGDKMJNKO)
	{
	}

	[Token(Token = "0x6005ABF")]
	[Address(RVA = "0x2D36314", Offset = "0x2D36314", VA = "0x2D36314")]
	public void RemoveLimitBlock(BlockData COGOOKNKDGF)
	{
	}

	[Token(Token = "0x6005AC0")]
	[Address(RVA = "0x2D33474", Offset = "0x2D33474", VA = "0x2D33474")]
	public bool ExistLimitBlock(string CJMGDKMJNKO)
	{
		return default(bool);
	}

	[Token(Token = "0x6005AC1")]
	[Address(RVA = "0x2D323FC", Offset = "0x2D323FC", VA = "0x2D323FC")]
	public void AddSpotInToSet(BE_BlockSpot COOOCAOMCJL)
	{
	}

	[Token(Token = "0x6005AC2")]
	[Address(RVA = "0x2D3E344", Offset = "0x2D3E344", VA = "0x2D3E344")]
	public void RemoveFromSpotsSet(BE_BlockSpot COOOCAOMCJL)
	{
	}

	[Token(Token = "0x6005AC3")]
	[Address(RVA = "0x2D22E24", Offset = "0x2D22E24", VA = "0x2D22E24")]
	public void RemoveHorizSpotFromSet(BE_SlotSpot COOOCAOMCJL)
	{
	}

	[Token(Token = "0x6005AC4")]
	[Address(RVA = "0x2D34550", Offset = "0x2D34550", VA = "0x2D34550")]
	public void AddSectionSpotToSet(BCEILEJONNO EGAOMGKFPOO)
	{
	}

	[Token(Token = "0x6005AC5")]
	[Address(RVA = "0x2D3E410", Offset = "0x2D3E410", VA = "0x2D3E410")]
	public void AddDataBlockSpotToSet(EKEOCIDDIFH LAPFKMCILPF)
	{
	}

	[Token(Token = "0x6005AC6")]
	[Address(RVA = "0x2D2B190", Offset = "0x2D2B190", VA = "0x2D2B190")]
	public BE_BlockSpot FindClosestSpotForBlockInAndOut(BCEILEJONNO EGAOMGKFPOO)
	{
		return null;
	}

	[Token(Token = "0x6005AC7")]
	[Address(RVA = "0x2D3E9B0", Offset = "0x2D3E9B0", VA = "0x2D3E9B0")]
	public BE_SlotSpot FindClosestSpotHoriz(BE_DataSpot OGPJEEKLDMN)
	{
		return null;
	}

	[Token(Token = "0x6005AC8")]
	[Address(RVA = "0x2D2BE6C", Offset = "0x2D2BE6C", VA = "0x2D2BE6C")]
	public void ShowHighLightSprite(bool KIFADCNJLBK, Vector3 ACCOJJMKKPM, Vector3 IOOPPDAAMEP)
	{
	}

	[Token(Token = "0x6005AC9")]
	[Address(RVA = "0x2D2AFE4", Offset = "0x2D2AFE4", VA = "0x2D2AFE4")]
	public void CloseHighLightSprite()
	{
	}

	[Token(Token = "0x6005ACA")]
	[Address(RVA = "0x2D3443C", Offset = "0x2D3443C", VA = "0x2D3443C")]
	public bool AddSectionToSectionsSet(BCEILEJONNO EGAOMGKFPOO)
	{
		return default(bool);
	}

	[Token(Token = "0x6005ACB")]
	[Address(RVA = "0x2D3179C", Offset = "0x2D3179C", VA = "0x2D3179C")]
	public void UpdateSectionDepth(BCEILEJONNO EGAOMGKFPOO)
	{
	}

	[Token(Token = "0x6005ACC")]
	[Address(RVA = "0x2D21A0C", Offset = "0x2D21A0C", VA = "0x2D21A0C")]
	public void RefreshMaxDepth(int KBMHNKKGDAN)
	{
	}

	[Token(Token = "0x6005ACD")]
	[Address(RVA = "0x2D35088", Offset = "0x2D35088", VA = "0x2D35088")]
	public void SetSectionDepthDraging(BCEILEJONNO EGAOMGKFPOO)
	{
	}

	[Token(Token = "0x6005ACE")]
	[Address(RVA = "0x2D3F564", Offset = "0x2D3F564", VA = "0x2D3F564")]
	public BCEILEJONNO FindDataAncestorSection(EKEOCIDDIFH LAPFKMCILPF)
	{
		return null;
	}

	[Token(Token = "0x6005ACF")]
	[Address(RVA = "0x2D3F274", Offset = "0x2D3F274", VA = "0x2D3F274")]
	public EKEOCIDDIFH FindDataBlockAncestorDataBlock(EKEOCIDDIFH LAPFKMCILPF)
	{
		return null;
	}

	[Token(Token = "0x6005AD0")]
	[Address(RVA = "0x2D3E748", Offset = "0x2D3E748", VA = "0x2D3E748")]
	public BCEILEJONNO FindSectionBlockAncestorSectionBlock(BCEILEJONNO MNIKFKDFIPN)
	{
		return null;
	}

	[Token(Token = "0x6005AD1")]
	[Address(RVA = "0x2D3FA2C", Offset = "0x2D3FA2C", VA = "0x2D3FA2C")]
	public void SetDataBlockDraggingDepth(EKEOCIDDIFH MMCGCPAONOA)
	{
	}

	[Token(Token = "0x6005AD2")]
	[Address(RVA = "0x2D3FB9C", Offset = "0x2D3FB9C", VA = "0x2D3FB9C")]
	public bool AddDataBlockToDataBlocksSet(EKEOCIDDIFH MMCGCPAONOA)
	{
		return default(bool);
	}

	[Token(Token = "0x6005AD3")]
	[Address(RVA = "0x2D3FCB0", Offset = "0x2D3FCB0", VA = "0x2D3FCB0")]
	public void UpdateDataBlockDepth(EKEOCIDDIFH MMCGCPAONOA)
	{
	}

	[Token(Token = "0x6005AD4")]
	[Address(RVA = "0x2D35570", Offset = "0x2D35570", VA = "0x2D35570")]
	public void DisableSectionCloneOnDrag(BCEILEJONNO EGAOMGKFPOO)
	{
	}

	[Token(Token = "0x6005AD5")]
	[Address(RVA = "0x2D407F4", Offset = "0x2D407F4", VA = "0x2D407F4")]
	public void DisableDataBlockCloneOnDrag(EKEOCIDDIFH LAPFKMCILPF)
	{
	}

	[Token(Token = "0x6005AD6")]
	[Address(RVA = "0x2D2D588", Offset = "0x2D2D588", VA = "0x2D2D588")]
	public void SetSectionColliderEnable(BCEILEJONNO EGAOMGKFPOO, bool ELOELMEPFCN)
	{
	}

	[Token(Token = "0x6005AD7")]
	[Address(RVA = "0x2D40C70", Offset = "0x2D40C70", VA = "0x2D40C70")]
	public void SetDataBlockColliderEnable(EKEOCIDDIFH LAPFKMCILPF, bool ELOELMEPFCN)
	{
	}

	[Token(Token = "0x6005AD8")]
	[Address(RVA = "0x2D411C0", Offset = "0x2D411C0", VA = "0x2D411C0")]
	public void SetSectionPreset(BCEILEJONNO EGAOMGKFPOO)
	{
	}

	[Token(Token = "0x6005AD9")]
	[Address(RVA = "0x2D41950", Offset = "0x2D41950", VA = "0x2D41950")]
	public void SetDataBlockPreset(EKEOCIDDIFH MMCGCPAONOA)
	{
	}

	[Token(Token = "0x6005ADA")]
	[Address(RVA = "0x2D41C94", Offset = "0x2D41C94", VA = "0x2D41C94")]
	public void PasteData()
	{
	}

	[Token(Token = "0x6005ADB")]
	[Address(RVA = "0x2D297C8", Offset = "0x2D297C8", VA = "0x2D297C8")]
	public void ShowCopyBtn(string MCJNDAJBBJL, Vector3 ACCOJJMKKPM, bool FNNLNOOIBMJ)
	{
	}

	[Token(Token = "0x6005ADC")]
	[Address(RVA = "0x2D42604", Offset = "0x2D42604", VA = "0x2D42604")]
	public void ShowPasteAndClearAllBtn()
	{
	}

	[Token(Token = "0x6005ADD")]
	[Address(RVA = "0x2D3DF9C", Offset = "0x2D3DF9C", VA = "0x2D3DF9C")]
	public void CanelMaskClick()
	{
	}

	[Token(Token = "0x6005ADE")]
	[Address(RVA = "0x2D42F0C", Offset = "0x2D42F0C", VA = "0x2D42F0C")]
	public void ClearAllBtnClick()
	{
	}

	[Token(Token = "0x6005ADF")]
	[Address(RVA = "0x2D43330", Offset = "0x2D43330", VA = "0x2D43330")]
	public void ClearGraphConfirmCallBack()
	{
	}

	[Token(Token = "0x6005AE0")]
	[Address(RVA = "0x2D43548", Offset = "0x2D43548", VA = "0x2D43548")]
	public void ClearCurrentGraph()
	{
	}

	[Token(Token = "0x6005AE1")]
	[Address(RVA = "0x2D28B74", Offset = "0x2D28B74", VA = "0x2D28B74")]
	public void SetSectionHighLight(BCEILEJONNO EGAOMGKFPOO, bool JLILFLCFCHA = false)
	{
	}

	[Token(Token = "0x6005AE2")]
	[Address(RVA = "0x2D4389C", Offset = "0x2D4389C", VA = "0x2D4389C")]
	public void SetDataBlockHighLight(EKEOCIDDIFH AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6005AE3")]
	[Address(RVA = "0x2D439D0", Offset = "0x2D439D0", VA = "0x2D439D0")]
	public void SetLocalVarHighLight(BE_BlockSectionHeader_LocalVarDefine BELPHADANNF)
	{
	}

	[Token(Token = "0x6005AE4")]
	[Address(RVA = "0x2D32650", Offset = "0x2D32650", VA = "0x2D32650")]
	public void CloseAllHighLight()
	{
	}

	[Token(Token = "0x6005AE5")]
	[Address(RVA = "0x2D33540", Offset = "0x2D33540", VA = "0x2D33540")]
	public bool CheckAllGraphItemLimit(int DAANIEIGCLE)
	{
		return default(bool);
	}

	[Token(Token = "0x6005AE6")]
	[Address(RVA = "0x2D43A5C", Offset = "0x2D43A5C", VA = "0x2D43A5C")]
	public bool CheckDataBlockNestLimit(BE_SlotSpot COOOCAOMCJL, BE_DataBlock LAPFKMCILPF)
	{
		return default(bool);
	}

	[Token(Token = "0x6005AE7")]
	[Address(RVA = "0x2D43F80", Offset = "0x2D43F80", VA = "0x2D43F80")]
	public int GetDataBlockDepth(EKEOCIDDIFH LAPFKMCILPF)
	{
		return default(int);
	}

	[Token(Token = "0x6005AE8")]
	[Address(RVA = "0x2D442A4", Offset = "0x2D442A4", VA = "0x2D442A4")]
	public void ResortAllBlockDepth()
	{
	}

	[Token(Token = "0x6005AE9")]
	[Address(RVA = "0x2D444B8", Offset = "0x2D444B8", VA = "0x2D444B8")]
	private void NGLECBHFJDD()
	{
	}

	[Token(Token = "0x6005AEA")]
	[Address(RVA = "0x2D44674", Offset = "0x2D44674", VA = "0x2D44674")]
	private void MPPGOMEBAGO()
	{
	}

	[Token(Token = "0x6005AEB")]
	[Address(RVA = "0x2D44830", Offset = "0x2D44830", VA = "0x2D44830")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005AED")]
	[Address(RVA = "0x2D44944", Offset = "0x2D44944", VA = "0x2D44944")]
	private static int GKDFPHIFCLF(BCEILEJONNO AAFBIANMEAL, BCEILEJONNO KENDCFNPDCE)
	{
		return default(int);
	}

	[Token(Token = "0x6005AEE")]
	[Address(RVA = "0x2D44AAC", Offset = "0x2D44AAC", VA = "0x2D44AAC")]
	private static int KMHMLPNHOBJ(EKEOCIDDIFH AAFBIANMEAL, EKEOCIDDIFH KENDCFNPDCE)
	{
		return default(int);
	}

	[Token(Token = "0x6005AEF")]
	[Address(RVA = "0x2D44C54", Offset = "0x2D44C54", VA = "0x2D44C54")]
	private void DIIKBPEPJAO()
	{
	}

	[Token(Token = "0x6005AF0")]
	[Address(RVA = "0x2D44C58", Offset = "0x2D44C58", VA = "0x2D44C58")]
	private void NDKEMAEECEK()
	{
	}
}
