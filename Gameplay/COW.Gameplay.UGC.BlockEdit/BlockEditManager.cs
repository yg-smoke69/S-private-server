using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B71")]
public class BlockEditManager : SingletonModule<BlockEditManager>, _Attribute
{
	[Token(Token = "0x2000B72")]
	private sealed class _003CGetGraphData_003Ec__AnonStorey0
	{
		[Token(Token = "0x4006139")]
		[FieldOffset(Offset = "0x8")]
		internal string gId;

		[Token(Token = "0x60056F3")]
		[Address(RVA = "0x37B2E24", Offset = "0x37B2E24", VA = "0x37B2E24")]
		public _003CGetGraphData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60056F4")]
		[Address(RVA = "0x37B9540", Offset = "0x37B9540", VA = "0x37B9540")]
		internal bool _003C_003Em__0(GraphData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000B73")]
	private sealed class _003CSetGraphDeleteState_003Ec__AnonStorey1
	{
		[Token(Token = "0x400613A")]
		[FieldOffset(Offset = "0x8")]
		internal string bindEntityId;

		[Token(Token = "0x60056F5")]
		[Address(RVA = "0x37B49EC", Offset = "0x37B49EC", VA = "0x37B49EC")]
		public _003CSetGraphDeleteState_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60056F6")]
		[Address(RVA = "0x37B9688", Offset = "0x37B9688", VA = "0x37B9688")]
		internal bool _003C_003Em__0(GraphData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000B74")]
	private sealed class _003CIsGlobalGraph_003Ec__AnonStorey2
	{
		[Token(Token = "0x400613B")]
		[FieldOffset(Offset = "0x8")]
		internal string graphId;

		[Token(Token = "0x60056F7")]
		[Address(RVA = "0x37B4D54", Offset = "0x37B4D54", VA = "0x37B4D54")]
		public _003CIsGlobalGraph_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60056F8")]
		[Address(RVA = "0x37B95E4", Offset = "0x37B95E4", VA = "0x37B95E4")]
		internal bool _003C_003Em__0(GraphData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4006133")]
	[FieldOffset(Offset = "0x0")]
	public static BlockEditContext BlockDefineContext;

	[Token(Token = "0x4006134")]
	[FieldOffset(Offset = "0xC")]
	public EditorEntityData EntityData;

	[Token(Token = "0x4006135")]
	[FieldOffset(Offset = "0x10")]
	private EBlockEditProjectType CurrentSaveProjectType;

	[Token(Token = "0x4006136")]
	[FieldOffset(Offset = "0x14")]
	private UIHudBlockEditMainController CacheUICtrl;

	[Token(Token = "0x4006137")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<GraphData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4006138")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<HADMLLCOEIO> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x170006F1")]
	public GraphData GlobalGraph
	{
		[Token(Token = "0x60056DE")]
		[Address(RVA = "0x37B4DD0", Offset = "0x37B4DD0", VA = "0x37B4DD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60056D1")]
	[Address(RVA = "0x37B2A90", Offset = "0x37B2A90", VA = "0x37B2A90")]
	public BlockEditManager()
	{
	}

	[Token(Token = "0x60056D2")]
	[Address(RVA = "0x37B2B28", Offset = "0x37B2B28", VA = "0x37B2B28", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60056D3")]
	[Address(RVA = "0x37B2B7C", Offset = "0x37B2B7C", VA = "0x37B2B7C", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60056D4")]
	[Address(RVA = "0x37B2C78", Offset = "0x37B2C78", VA = "0x37B2C78")]
	public GraphData GetGraphData(string gId)
	{
		return null;
	}

	[Token(Token = "0x60056D5")]
	[Address(RVA = "0x37B2E2C", Offset = "0x37B2E2C", VA = "0x37B2E2C")]
	private void LoadBlockDefine()
	{
	}

	[Token(Token = "0x60056D6")]
	[Address(RVA = "0x37B3554", Offset = "0x37B3554", VA = "0x37B3554")]
	private void LoadBlockLibrary()
	{
	}

	[Token(Token = "0x60056D7")]
	[Address(RVA = "0x37B3C68", Offset = "0x37B3C68", VA = "0x37B3C68")]
	public void LoadBlockDefineAndLib()
	{
	}

	[Token(Token = "0x60056D8")]
	[Address(RVA = "0x37B3D78", Offset = "0x37B3D78", VA = "0x37B3D78")]
	public void OpenGraphEditUI(string gId)
	{
	}

	[Token(Token = "0x60056D9")]
	[Address(RVA = "0x37B3F68", Offset = "0x37B3F68", VA = "0x37B3F68")]
	public GraphData AddGraph(string entityID)
	{
		return null;
	}

	[Token(Token = "0x60056DA")]
	[Address(RVA = "0x37B4468", Offset = "0x37B4468", VA = "0x37B4468")]
	public GraphData AddGraph(FONLAPPBCOO logicEntityType)
	{
		return null;
	}

	[Token(Token = "0x60056DB")]
	[Address(RVA = "0x37B4810", Offset = "0x37B4810", VA = "0x37B4810")]
	public void SetGraphDeleteState(string bindEntityId, bool b)
	{
	}

	[Token(Token = "0x60056DC")]
	[Address(RVA = "0x37B49F4", Offset = "0x37B49F4", VA = "0x37B49F4")]
	public bool IsGlobalGraph(string graphId)
	{
		return default(bool);
	}

	[Token(Token = "0x60056DD")]
	[Address(RVA = "0x37B4D5C", Offset = "0x37B4D5C", VA = "0x37B4D5C")]
	public bool IsForTypeGraph(FONLAPPBCOO logicEntityType)
	{
		return default(bool);
	}

	[Token(Token = "0x60056DF")]
	[Address(RVA = "0x37B4FD8", Offset = "0x37B4FD8", VA = "0x37B4FD8")]
	public bool IsCopyContentExist()
	{
		return default(bool);
	}

	[Token(Token = "0x60056E0")]
	[Address(RVA = "0x37B5298", Offset = "0x37B5298", VA = "0x37B5298")]
	public BlockData GetCopyBlockData(Dictionary<string, LocalVarDefineData> localVarDefines)
	{
		return null;
	}

	[Token(Token = "0x60056E1")]
	[Address(RVA = "0x37B5B54", Offset = "0x37B5B54", VA = "0x37B5B54")]
	public void RemoveGraph(string graphID)
	{
	}

	[Token(Token = "0x60056E2")]
	[Address(RVA = "0x37B5F5C", Offset = "0x37B5F5C", VA = "0x37B5F5C")]
	public string GetEntityIDFromGraphID(string graphID)
	{
		return null;
	}

	[Token(Token = "0x60056E3")]
	[Address(RVA = "0x37B6068", Offset = "0x37B6068", VA = "0x37B6068")]
	public FONLAPPBCOO GetEntityTypeFromGraphID(string graphID)
	{
		return default(FONLAPPBCOO);
	}

	[Token(Token = "0x60056E4")]
	[Address(RVA = "0x37B60F8", Offset = "0x37B60F8", VA = "0x37B60F8")]
	public bool ExtractEventTypeUGCCustomModeMapContent(byte[] projectDataBytes, EditorEntityData editorEntityData, EventLogger.EventTypeUGCCustomModeMapContent output)
	{
		return default(bool);
	}

	[Token(Token = "0x60056E5")]
	[Address(RVA = "0x37B6258", Offset = "0x37B6258", VA = "0x37B6258", Slot = "10")]
	public bool LoadProject(byte[] projectDataBytes, EditorEntityData editorEntityData)
	{
		return default(bool);
	}

	[Token(Token = "0x60056E6")]
	[Address(RVA = "0x37B6C04", Offset = "0x37B6C04", VA = "0x37B6C04", Slot = "11")]
	private bool COW_002EGameplay_002EUGC_002EIUGCEditor_003CSystem_002ECollections_002EGeneric_002EList_003Cmessage_002EUGCGraphData_003E_003E_002EUnloadProject()
	{
		return default(bool);
	}

	[Token(Token = "0x60056E7")]
	[Address(RVA = "0x37B6C5C", Offset = "0x37B6C5C", VA = "0x37B6C5C", Slot = "12")]
	private bool COW_002EGameplay_002EUGC_002EIUGCEditor_003CSystem_002ECollections_002EGeneric_002EList_003Cmessage_002EUGCGraphData_003E_003E_002EExport(out byte[] projectDataBytes, out List<JGIADJOKNHI> runtimeData, ref EditorMiscData miscData)
	{
		return default(bool);
	}

	[Token(Token = "0x60056E8")]
	private byte[] ToBytes<T>(T data)
	{
		return null;
	}

	[Token(Token = "0x60056E9")]
	private T ToObject<T>(byte[] bytes)
	{
		return (T)null;
	}

	[Token(Token = "0x60056EA")]
	[Address(RVA = "0x37B73A4", Offset = "0x37B73A4", VA = "0x37B73A4")]
	private byte[] GraphDataToBytes()
	{
		return null;
	}

	[Token(Token = "0x60056EB")]
	[Address(RVA = "0x37B67E8", Offset = "0x37B67E8", VA = "0x37B67E8")]
	private bool BuildGraphs(byte[] bytes)
	{
		return default(bool);
	}

	[Token(Token = "0x60056EC")]
	[Address(RVA = "0x37B7610", Offset = "0x37B7610", VA = "0x37B7610")]
	public void SaveProjectDataLocally()
	{
	}

	[Token(Token = "0x60056ED")]
	[Address(RVA = "0x37B8538", Offset = "0x37B8538", VA = "0x37B8538")]
	public void SaveGraphLocally(string filename)
	{
	}

	[Token(Token = "0x60056EE")]
	[Address(RVA = "0x37B8AEC", Offset = "0x37B8AEC", VA = "0x37B8AEC")]
	public void LoadGraphLocally()
	{
	}

	[Token(Token = "0x60056EF")]
	[Address(RVA = "0x37B7F80", Offset = "0x37B7F80", VA = "0x37B7F80")]
	public static void MockGraphToUserLevelData(BlockEditContext context, OANAFPLDDNI levelData)
	{
	}

	[Token(Token = "0x60056F1")]
	[Address(RVA = "0x37B94E0", Offset = "0x37B94E0", VA = "0x37B94E0")]
	private static bool _003Cget_GlobalGraph_003Em__0(GraphData e)
	{
		return default(bool);
	}

	[Token(Token = "0x60056F2")]
	[Address(RVA = "0x37B950C", Offset = "0x37B950C", VA = "0x37B950C")]
	private static bool _003CMockGraphToUserLevelData_003Em__1(HADMLLCOEIO item)
	{
		return default(bool);
	}
}
