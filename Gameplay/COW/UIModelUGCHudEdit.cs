using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using COW.Gameplay.UGC;
using COW.Gameplay.UGC.BlockEdit;
using COW.UGCHudEdit;
using GCommon;
using GCommon.CommandPattern;
using GCommon.UGCUI;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2003284")]
public class UIModelUGCHudEdit : UIBaseModel, _Attribute, IConvertible
{
	[Token(Token = "0x2003285")]
	private sealed class _003CGetHudEventBlockInfos_003Ec__AnonStorey0
	{
		[Token(Token = "0x401340B")]
		[FieldOffset(Offset = "0x8")]
		internal List<UGCHudEventBlockInfo> list;

		[Token(Token = "0x601551E")]
		[Address(RVA = "0x169B360", Offset = "0x169B360", VA = "0x169B360")]
		public _003CGetHudEventBlockInfos_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601551F")]
		[Address(RVA = "0x169F834", Offset = "0x169F834", VA = "0x169F834")]
		internal bool _003C_003Em__0(HNPNMOHNBLN child)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003286")]
	private sealed class _003CFindPrefabData_003Ec__AnonStorey1
	{
		[Token(Token = "0x401340C")]
		[FieldOffset(Offset = "0x8")]
		internal uint Id;

		[Token(Token = "0x6015520")]
		[Address(RVA = "0x169D6B0", Offset = "0x169D6B0", VA = "0x169D6B0")]
		public _003CFindPrefabData_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6015521")]
		[Address(RVA = "0x169F6A4", Offset = "0x169F6A4", VA = "0x169F6A4")]
		internal bool _003C_003Em__0(BIHLLJGEDDM x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003287")]
	private sealed class _003CGetIconResData_003Ec__AnonStorey2
	{
		[Token(Token = "0x401340D")]
		[FieldOffset(Offset = "0x8")]
		internal string spriteName;

		[Token(Token = "0x6015522")]
		[Address(RVA = "0x169DA44", Offset = "0x169DA44", VA = "0x169DA44")]
		public _003CGetIconResData_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6015523")]
		[Address(RVA = "0x169F998", Offset = "0x169F998", VA = "0x169F998")]
		internal bool _003C_003Em__0(OPPOFFMJNNH x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003288")]
	private sealed class _003CFindPrefabDataIndex_003Ec__AnonStorey3
	{
		[Token(Token = "0x401340E")]
		[FieldOffset(Offset = "0x8")]
		internal uint Id;

		[Token(Token = "0x6015524")]
		[Address(RVA = "0x169DCC0", Offset = "0x169DCC0", VA = "0x169DCC0")]
		public _003CFindPrefabDataIndex_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6015525")]
		[Address(RVA = "0x169F7D0", Offset = "0x169F7D0", VA = "0x169F7D0")]
		internal bool _003C_003Em__0(BIHLLJGEDDM x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003289")]
	private sealed class _003CFindPrefabDataForEditor_003Ec__AnonStorey4
	{
		[Token(Token = "0x401340F")]
		[FieldOffset(Offset = "0x8")]
		internal uint Id;

		[Token(Token = "0x6015526")]
		[Address(RVA = "0x169DDC4", Offset = "0x169DDC4", VA = "0x169DDC4")]
		public _003CFindPrefabDataForEditor_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6015527")]
		[Address(RVA = "0x169F708", Offset = "0x169F708", VA = "0x169F708")]
		internal bool _003C_003Em__0(AONDOMHABOH x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200328A")]
	private sealed class _003CFindPrefabDataForEditorIndex_003Ec__AnonStorey5
	{
		[Token(Token = "0x4013410")]
		[FieldOffset(Offset = "0x8")]
		internal uint Id;

		[Token(Token = "0x6015528")]
		[Address(RVA = "0x169DDCC", Offset = "0x169DDCC", VA = "0x169DDCC")]
		public _003CFindPrefabDataForEditorIndex_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6015529")]
		[Address(RVA = "0x169F76C", Offset = "0x169F76C", VA = "0x169F76C")]
		internal bool _003C_003Em__0(AONDOMHABOH x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200328B")]
	private sealed class _003CExtractEventTypeUGCCustomModeMapContent_003Ec__AnonStorey6
	{
		[Token(Token = "0x4013411")]
		[FieldOffset(Offset = "0x8")]
		internal EventLogger.EventTypeUGCCustomModeMapContent.HudInfo hudInfo;

		[Token(Token = "0x601552A")]
		[Address(RVA = "0x169E41C", Offset = "0x169E41C", VA = "0x169E41C")]
		public _003CExtractEventTypeUGCCustomModeMapContent_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x601552B")]
		[Address(RVA = "0x169F5E8", Offset = "0x169F5E8", VA = "0x169F5E8")]
		internal bool _003C_003Em__0(HNPNMOHNBLN child)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200328C")]
	private sealed class _003CHasWidgetForEditor_003Ec__AnonStorey7
	{
		[Token(Token = "0x4013412")]
		[FieldOffset(Offset = "0x8")]
		internal uint widgetID;

		[Token(Token = "0x4013413")]
		[FieldOffset(Offset = "0xC")]
		internal bool has;

		[Token(Token = "0x601552C")]
		[Address(RVA = "0x169F360", Offset = "0x169F360", VA = "0x169F360")]
		public _003CHasWidgetForEditor_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x601552D")]
		[Address(RVA = "0x169FA3C", Offset = "0x169FA3C", VA = "0x169FA3C")]
		internal bool _003C_003Em__0(HNPNMOHNBLN child)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40133F4")]
	[FieldOffset(Offset = "0xC")]
	private CommandManager m_CommandManager;

	[Token(Token = "0x40133F5")]
	[FieldOffset(Offset = "0x10")]
	private CommandFactory m_CommandFactory;

	[Token(Token = "0x40133F6")]
	[FieldOffset(Offset = "0x14")]
	private UGCHudPrefabDataProcessor m_PrefabDataProcessor;

	[Token(Token = "0x40133F7")]
	[FieldOffset(Offset = "0x18")]
	private UniqueIDGenerator m_IDGenerator;

	[Token(Token = "0x40133F8")]
	[FieldOffset(Offset = "0x1C")]
	private UniqueIDGenerator m_HudIdGenerator;

	[Token(Token = "0x40133F9")]
	[FieldOffset(Offset = "0x20")]
	private GameObjectRecycleBin m_HudWidgetRecycleBin;

	[Token(Token = "0x40133FA")]
	[FieldOffset(Offset = "0x24")]
	private HBLLODDOMEH m_PrefabDatas;

	[Token(Token = "0x40133FB")]
	[FieldOffset(Offset = "0x28")]
	private EAGFEBBJPBF m_PrefabDatasForEditor;

	[Token(Token = "0x40133FC")]
	[FieldOffset(Offset = "0x2C")]
	private EditorEntityData m_EntityData;

	[Token(Token = "0x40133FD")]
	[FieldOffset(Offset = "0x30")]
	private UGCHudWidget m_CurrentHudWidget;

	[Token(Token = "0x40133FE")]
	[FieldOffset(Offset = "0x34")]
	private DragWidgetSelectorCommand m_DragSelectorCommand;

	[Token(Token = "0x40133FF")]
	[FieldOffset(Offset = "0x38")]
	private AdjustHudWidgetSelectorSizeCommand m_AdjustSelectorSizeCommand;

	[Token(Token = "0x4013400")]
	[FieldOffset(Offset = "0x3C")]
	private AdjustHudWidgetSelectorAngleCommand m_AdjustSelectorAngleCommand;

	[Token(Token = "0x4013401")]
	[FieldOffset(Offset = "0x40")]
	public Action<UGCHudWidget> onCurrentHudWidgetChanged;

	[Token(Token = "0x4013402")]
	[FieldOffset(Offset = "0x44")]
	public Action<UGCHudWidget> onAddHudWidget;

	[Token(Token = "0x4013403")]
	[FieldOffset(Offset = "0x48")]
	public Action<UGCHudWidget> onRemoveHudWidget;

	[Token(Token = "0x4013404")]
	[FieldOffset(Offset = "0x4C")]
	private List<OPPOFFMJNNH> m_HudIconResDataList;

	[Token(Token = "0x4013405")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsEditor;

	[Token(Token = "0x4013406")]
	[FieldOffset(Offset = "0x54")]
	private int UNDO_LIMIT;

	[Token(Token = "0x4013407")]
	[FieldOffset(Offset = "0x58")]
	private uint m_CurrentEditHudID;

	[Token(Token = "0x4013408")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_MaxCurrentHudWigetID;

	[Token(Token = "0x4013409")]
	[FieldOffset(Offset = "0x60")]
	private int m_CurrentUGCMode;

	[Token(Token = "0x401340A")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<AONDOMHABOH> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x1700167A")]
	public bool HudEditEnabled
	{
		[Token(Token = "0x60154D3")]
		[Address(RVA = "0x1699984", Offset = "0x1699984", VA = "0x1699984")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700167B")]
	public CommandManager CommandManager
	{
		[Token(Token = "0x60154D4")]
		[Address(RVA = "0x1699BF4", Offset = "0x1699BF4", VA = "0x1699BF4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700167C")]
	public CommandFactory CommandFactory
	{
		[Token(Token = "0x60154D5")]
		[Address(RVA = "0x1699C4C", Offset = "0x1699C4C", VA = "0x1699C4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700167D")]
	public UGCHudPrefabDataProcessor PrefabProcessor
	{
		[Token(Token = "0x60154D6")]
		[Address(RVA = "0x1699CA4", Offset = "0x1699CA4", VA = "0x1699CA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700167E")]
	public GameObjectRecycleBin RecycleBin
	{
		[Token(Token = "0x60154D7")]
		[Address(RVA = "0x1699CFC", Offset = "0x1699CFC", VA = "0x1699CFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700167F")]
	public UGCHudWidget CurrentHudWidget
	{
		[Token(Token = "0x60154D8")]
		[Address(RVA = "0x169A01C", Offset = "0x169A01C", VA = "0x169A01C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60154D9")]
		[Address(RVA = "0x169A074", Offset = "0x169A074", VA = "0x169A074")]
		set
		{
		}
	}

	[Token(Token = "0x17001680")]
	public uint CurrentEditHudID
	{
		[Token(Token = "0x60154DA")]
		[Address(RVA = "0x169A228", Offset = "0x169A228", VA = "0x169A228")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60154DB")]
		[Address(RVA = "0x169A280", Offset = "0x169A280", VA = "0x169A280")]
		set
		{
		}
	}

	[Token(Token = "0x17001681")]
	public uint MaxCurrentHudWidgetID
	{
		[Token(Token = "0x60154DC")]
		[Address(RVA = "0x169A34C", Offset = "0x169A34C", VA = "0x169A34C")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x60154D2")]
	[Address(RVA = "0x169987C", Offset = "0x169987C", VA = "0x169987C")]
	public UIModelUGCHudEdit()
	{
	}

	[Token(Token = "0x60154DD")]
	[Address(RVA = "0x169A3A4", Offset = "0x169A3A4", VA = "0x169A3A4", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60154DE")]
	[Address(RVA = "0x169A3FC", Offset = "0x169A3FC", VA = "0x169A3FC", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x60154DF")]
	[Address(RVA = "0x169A54C", Offset = "0x169A54C", VA = "0x169A54C", Slot = "11")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60154E0")]
	[Address(RVA = "0x169A5C4", Offset = "0x169A5C4", VA = "0x169A5C4", Slot = "13")]
	public override void ClearCache()
	{
	}

	[Token(Token = "0x60154E1")]
	[Address(RVA = "0x169A68C", Offset = "0x169A68C", VA = "0x169A68C")]
	public uint GetUniqueID()
	{
		return default(uint);
	}

	[Token(Token = "0x60154E2")]
	[Address(RVA = "0x169A708", Offset = "0x169A708", VA = "0x169A708")]
	public uint GetHudUniqueID()
	{
		return default(uint);
	}

	[Token(Token = "0x60154E3")]
	[Address(RVA = "0x1699DFC", Offset = "0x1699DFC", VA = "0x1699DFC")]
	public void SetHudWidgetRecycleBin(Transform binRoot)
	{
	}

	[Token(Token = "0x60154E4")]
	[Address(RVA = "0x169A780", Offset = "0x169A780", VA = "0x169A780")]
	public List<UGCHudPrefabIndexInfo> GetUGCHudPrefabIndexInfoList()
	{
		return null;
	}

	[Token(Token = "0x60154E5")]
	[Address(RVA = "0x169AB6C", Offset = "0x169AB6C", VA = "0x169AB6C")]
	public List<UGCHudWidgetIndexInfo> GetUGCHudWidgetIndexInfoList(uint hudID)
	{
		return null;
	}

	[Token(Token = "0x60154E6")]
	[Address(RVA = "0x169AE2C", Offset = "0x169AE2C", VA = "0x169AE2C")]
	private void AddUGCHudWidgetIndexInfo(List<HNPNMOHNBLN> children, List<UGCHudWidgetIndexInfo> destList, bool recursive)
	{
	}

	[Token(Token = "0x60154E7")]
	[Address(RVA = "0x169B0FC", Offset = "0x169B0FC", VA = "0x169B0FC")]
	public List<UGCHudEventBlockInfo> GetHudEventBlockInfos(string hudId)
	{
		return null;
	}

	[Token(Token = "0x60154E8")]
	[Address(RVA = "0x169B184", Offset = "0x169B184", VA = "0x169B184")]
	public List<UGCHudEventBlockInfo> GetHudEventBlockInfos(uint hudID)
	{
		return null;
	}

	[Token(Token = "0x60154E9")]
	[Address(RVA = "0x169AAF8", Offset = "0x169AAF8", VA = "0x169AAF8")]
	public List<AONDOMHABOH> GetCurrentHudPrefabDataListForEditor()
	{
		return null;
	}

	[Token(Token = "0x60154EA")]
	[Address(RVA = "0x169B57C", Offset = "0x169B57C", VA = "0x169B57C")]
	public void AddHudPrefabData(AONDOMHABOH prefabData)
	{
	}

	[Token(Token = "0x60154EB")]
	[Address(RVA = "0x169B65C", Offset = "0x169B65C", VA = "0x169B65C")]
	public void RemoveHudPrefabData(uint hudId)
	{
	}

	[Token(Token = "0x60154EC")]
	[Address(RVA = "0x169BB6C", Offset = "0x169BB6C", VA = "0x169BB6C")]
	public void Undo()
	{
	}

	[Token(Token = "0x60154ED")]
	[Address(RVA = "0x169BBE4", Offset = "0x169BBE4", VA = "0x169BBE4")]
	public void Redo()
	{
	}

	[Token(Token = "0x60154EE")]
	[Address(RVA = "0x169BC5C", Offset = "0x169BC5C", VA = "0x169BC5C")]
	public UGCHudWidget CreateHudWidget(UGCHudWidgetType hudType, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60154EF")]
	[Address(RVA = "0x169C028", Offset = "0x169C028", VA = "0x169C028")]
	public void DeleteHudWidget(UGCHudWidget widget)
	{
	}

	[Token(Token = "0x60154F0")]
	[Address(RVA = "0x169C1DC", Offset = "0x169C1DC", VA = "0x169C1DC")]
	public void SetCurrentHudWidget(UGCHudWidget widget)
	{
	}

	[Token(Token = "0x60154F1")]
	[Address(RVA = "0x169C248", Offset = "0x169C248", VA = "0x169C248")]
	public void DragSelectorStart(UIUGCHudWidgetSelectorController selector)
	{
	}

	[Token(Token = "0x60154F2")]
	[Address(RVA = "0x169C3B0", Offset = "0x169C3B0", VA = "0x169C3B0")]
	public void DragSelectorEnd()
	{
	}

	[Token(Token = "0x60154F3")]
	[Address(RVA = "0x169C454", Offset = "0x169C454", VA = "0x169C454")]
	public void StartAdjustSelectorSize(UIUGCHudWidgetSelectorController selector, Pivot pivotType)
	{
	}

	[Token(Token = "0x60154F4")]
	[Address(RVA = "0x169C5F4", Offset = "0x169C5F4", VA = "0x169C5F4")]
	public void EndAdjustSelectorSize(Pivot pivotType)
	{
	}

	[Token(Token = "0x60154F5")]
	[Address(RVA = "0x169C6A4", Offset = "0x169C6A4", VA = "0x169C6A4")]
	public void StartAdjustSelectorAngle(UIUGCHudWidgetSelectorController selector)
	{
	}

	[Token(Token = "0x60154F6")]
	[Address(RVA = "0x169C79C", Offset = "0x169C79C", VA = "0x169C79C")]
	public void EndAdjustSelectorAngle()
	{
	}

	[Token(Token = "0x60154F7")]
	[Address(RVA = "0x169C82C", Offset = "0x169C82C", VA = "0x169C82C")]
	public void SetHudWidgetLocalAngleZ(UGCHudWidget widget, float localAngleZ)
	{
	}

	[Token(Token = "0x60154F8")]
	[Address(RVA = "0x169C960", Offset = "0x169C960", VA = "0x169C960")]
	public void SetHudWidgetName(UGCHudWidget widget, string name)
	{
	}

	[Token(Token = "0x60154F9")]
	[Address(RVA = "0x169CA94", Offset = "0x169CA94", VA = "0x169CA94")]
	public void SetHudWidgetSize(UGCHudWidget widget, int width, int height)
	{
	}

	[Token(Token = "0x60154FA")]
	[Address(RVA = "0x169CBD4", Offset = "0x169CBD4", VA = "0x169CBD4")]
	public void SetHudWidgetAnchorPosition(UGCHudWidget widget, float anchorPositionX, float anchorPositionY)
	{
	}

	[Token(Token = "0x60154FB")]
	[Address(RVA = "0x169CD28", Offset = "0x169CD28", VA = "0x169CD28")]
	private Command GetSelectHudWidgetCommand(UGCHudWidget widget)
	{
		return null;
	}

	[Token(Token = "0x60154FC")]
	[Address(RVA = "0x169C2B8", Offset = "0x169C2B8", VA = "0x169C2B8")]
	private DragWidgetSelectorCommand GetDragSelectorCommand(UIUGCHudWidgetSelectorController selector)
	{
		return null;
	}

	[Token(Token = "0x60154FD")]
	[Address(RVA = "0x169C4E0", Offset = "0x169C4E0", VA = "0x169C4E0")]
	private AdjustHudWidgetSelectorSizeCommand GetAdjustSelectorSizeCommand(UIUGCHudWidgetSelectorController selector, Pivot pivotType)
	{
		return null;
	}

	[Token(Token = "0x60154FE")]
	[Address(RVA = "0x169CE20", Offset = "0x169CE20", VA = "0x169CE20")]
	public void SaveHudPrefab(UGCHudPrefabRoot prefabRoot)
	{
	}

	[Token(Token = "0x60154FF")]
	[Address(RVA = "0x169D208", Offset = "0x169D208", VA = "0x169D208")]
	public void SaveToFile()
	{
	}

	[Token(Token = "0x6015500")]
	[Address(RVA = "0x169D25C", Offset = "0x169D25C", VA = "0x169D25C")]
	public GameObject RebuildPrefab(uint Id, Transform root, bool isEditor = true)
	{
		return null;
	}

	[Token(Token = "0x6015501")]
	[Address(RVA = "0x169D318", Offset = "0x169D318", VA = "0x169D318")]
	public GameObject RebuildPrefab(AONDOMHABOH prefabData, Transform root)
	{
		return null;
	}

	[Token(Token = "0x6015502")]
	[Address(RVA = "0x169D5FC", Offset = "0x169D5FC", VA = "0x169D5FC")]
	public GameObject RebuildPrefab(BIHLLJGEDDM prefabData, Transform root)
	{
		return null;
	}

	[Token(Token = "0x6015503")]
	[Address(RVA = "0x169D498", Offset = "0x169D498", VA = "0x169D498")]
	public BIHLLJGEDDM FindPrefabData(uint Id)
	{
		return null;
	}

	[Token(Token = "0x6015504")]
	[Address(RVA = "0x169D6B8", Offset = "0x169D6B8", VA = "0x169D6B8")]
	public OPPOFFMJNNH GetIconResData(string spriteName)
	{
		return null;
	}

	[Token(Token = "0x6015505")]
	[Address(RVA = "0x169DB60", Offset = "0x169DB60", VA = "0x169DB60")]
	private int FindPrefabDataIndex(uint Id)
	{
		return default(int);
	}

	[Token(Token = "0x6015506")]
	[Address(RVA = "0x169DCC8", Offset = "0x169DCC8", VA = "0x169DCC8")]
	private bool RemovePrefabData(uint Id)
	{
		return default(bool);
	}

	[Token(Token = "0x6015507")]
	[Address(RVA = "0x169ACC8", Offset = "0x169ACC8", VA = "0x169ACC8")]
	private AONDOMHABOH FindPrefabDataForEditor(uint Id)
	{
		return null;
	}

	[Token(Token = "0x6015508")]
	[Address(RVA = "0x169D0A8", Offset = "0x169D0A8", VA = "0x169D0A8")]
	private int FindPrefabDataForEditorIndex(uint Id)
	{
		return default(int);
	}

	[Token(Token = "0x6015509")]
	[Address(RVA = "0x169B7C8", Offset = "0x169B7C8", VA = "0x169B7C8")]
	private bool RemovePrefabDataForEditor(uint Id)
	{
		return default(bool);
	}

	[Token(Token = "0x601550A")]
	[Address(RVA = "0x169B368", Offset = "0x169B368", VA = "0x169B368")]
	private void ForeachWidget(List<HNPNMOHNBLN> children, Func<HNPNMOHNBLN, bool> process, bool recursive = true)
	{
	}

	[Token(Token = "0x601550B")]
	[Address(RVA = "0x169A168", Offset = "0x169A168", VA = "0x169A168")]
	private void OnCurrentHudWidgetChanged(UGCHudWidget cur)
	{
	}

	[Token(Token = "0x601550C")]
	[Address(RVA = "0x169A2F8", Offset = "0x169A2F8", VA = "0x169A2F8")]
	private void OnCurrentEditHudChanged()
	{
	}

	[Token(Token = "0x601550D")]
	[Address(RVA = "0x169DDD4", Offset = "0x169DDD4", VA = "0x169DDD4")]
	public bool ExtractEventTypeUGCCustomModeMapContent(byte[] projectDataBytes, EditorEntityData editorEntityData, EventLogger.EventTypeUGCCustomModeMapContent output)
	{
		return default(bool);
	}

	[Token(Token = "0x601550E")]
	[Address(RVA = "0x169E424", Offset = "0x169E424", VA = "0x169E424", Slot = "14")]
	public bool LoadProject(byte[] projectDataBytes, [Optional] EditorEntityData editorEntityData)
	{
		return default(bool);
	}

	[Token(Token = "0x601550F")]
	[Address(RVA = "0x169E92C", Offset = "0x169E92C", VA = "0x169E92C", Slot = "15")]
	public bool UnloadProject()
	{
		return default(bool);
	}

	[Token(Token = "0x6015510")]
	[Address(RVA = "0x169E984", Offset = "0x169E984", VA = "0x169E984", Slot = "16")]
	public bool Export(out byte[] projectDataBytes, out HBLLODDOMEH runtimeData, ref EditorMiscData miscData)
	{
		return default(bool);
	}

	[Token(Token = "0x6015511")]
	[Address(RVA = "0x169EBF8", Offset = "0x169EBF8", VA = "0x169EBF8", Slot = "17")]
	public bool LoadRuntimeData(HBLLODDOMEH runtimeData)
	{
		return default(bool);
	}

	[Token(Token = "0x6015512")]
	[Address(RVA = "0x169EC68", Offset = "0x169EC68", VA = "0x169EC68", Slot = "18")]
	public bool UnloadRuntimeData()
	{
		return default(bool);
	}

	[Token(Token = "0x6015513")]
	[Address(RVA = "0x169B8C4", Offset = "0x169B8C4", VA = "0x169B8C4")]
	public string GetGraphId(string entityId, bool createIfMissing = true)
	{
		return null;
	}

	[Token(Token = "0x6015514")]
	[Address(RVA = "0x169ECCC", Offset = "0x169ECCC", VA = "0x169ECCC")]
	public GraphData GetGraphData(uint hudId, bool createIfMissing = true)
	{
		return null;
	}

	[Token(Token = "0x6015515")]
	[Address(RVA = "0x169EE50", Offset = "0x169EE50", VA = "0x169EE50")]
	public BlockData FindHudEventBlock(uint hudId, uint widgetId)
	{
		return null;
	}

	[Token(Token = "0x6015516")]
	[Address(RVA = "0x169F168", Offset = "0x169F168", VA = "0x169F168")]
	public bool HasHudPrefabForEditor(uint hudID)
	{
		return default(bool);
	}

	[Token(Token = "0x6015517")]
	[Address(RVA = "0x169F1E4", Offset = "0x169F1E4", VA = "0x169F1E4")]
	public bool HasWidgetForEditor(uint hudID, uint widgetID)
	{
		return default(bool);
	}

	[Token(Token = "0x6015518")]
	[Address(RVA = "0x169F368", Offset = "0x169F368", VA = "0x169F368")]
	private void _003CSetHudWidgetRecycleBin_003Em__0(GameObject go)
	{
	}

	[Token(Token = "0x6015519")]
	[Address(RVA = "0x169F464", Offset = "0x169F464", VA = "0x169F464")]
	private void _003CSetHudWidgetRecycleBin_003Em__1(GameObject go)
	{
	}

	[Token(Token = "0x601551A")]
	[Address(RVA = "0x169F560", Offset = "0x169F560", VA = "0x169F560")]
	private static int _003CGetUGCHudPrefabIndexInfoList_003Em__2(AONDOMHABOH a, AONDOMHABOH b)
	{
		return default(int);
	}

	[Token(Token = "0x601551B")]
	[Address(RVA = "0x169F5D0", Offset = "0x169F5D0", VA = "0x169F5D0")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x601551C")]
	[Address(RVA = "0x169F5D8", Offset = "0x169F5D8", VA = "0x169F5D8")]
	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	[Token(Token = "0x601551D")]
	[Address(RVA = "0x169F5E0", Offset = "0x169F5E0", VA = "0x169F5E0")]
	public void _003C_003EiFixBaseProxy_ClearCache()
	{
	}
}
