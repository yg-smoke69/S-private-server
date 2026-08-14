using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003EDE")]
public class Grid2D<T> where T : GridValueBase, new()
{
	[Token(Token = "0x401A892")]
	[FieldOffset(Offset = "0x0")]
	private Rectangle2D m_Shape;

	[Token(Token = "0x401A893")]
	[FieldOffset(Offset = "0x0")]
	private float m_HalfLength;

	[Token(Token = "0x401A894")]
	[FieldOffset(Offset = "0x0")]
	private float m_HalfWidth;

	[Token(Token = "0x401A895")]
	[FieldOffset(Offset = "0x0")]
	private int m_ColumnCount;

	[Token(Token = "0x401A896")]
	[FieldOffset(Offset = "0x0")]
	private int m_RowCount;

	[Token(Token = "0x401A897")]
	[FieldOffset(Offset = "0x0")]
	private Dictionary<int, T> m_Values;

	[Token(Token = "0x401A898")]
	[FieldOffset(Offset = "0x0")]
	private int m_GridCount;

	[Token(Token = "0x401A899")]
	[FieldOffset(Offset = "0x0")]
	private Vector2 m_GridSize;

	[Token(Token = "0x17001BFA")]
	public int ColumnCount
	{
		[Token(Token = "0x6019992")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6019990")]
	public Grid2D(Vector3 pos, float length, float width, float grid_length_size, float grid_width_size)
	{
	}

	[Token(Token = "0x6019991")]
	public Grid2D(Vector3 leftBottom, Vector3 rightTop, float grid_length_size, float grid_width_size)
	{
	}

	[Token(Token = "0x6019993")]
	public Dictionary<int, T> GetAllValues()
	{
		return null;
	}

	[Token(Token = "0x6019994")]
	public T GetValue(Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6019995")]
	public List<T> GetValusArroundPosition(Vector3 pos, int radius, [Optional] List<T> resultList)
	{
		return null;
	}

	[Token(Token = "0x6019996")]
	public List<T> GetValuesArroundIndex(int index, int radius, List<T> resultList)
	{
		return null;
	}

	[Token(Token = "0x6019997")]
	public Vector3 GetGridCoordinateByIndex(int index)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019998")]
	public void SetValue(Vector3 pos, T value)
	{
	}

	[Token(Token = "0x6019999")]
	public T GetValue(int index)
	{
		return null;
	}

	[Token(Token = "0x601999A")]
	public void SetValue(int index, T value)
	{
	}

	[Token(Token = "0x601999B")]
	public bool IsPointInside(Vector3 pos, float margin = 0f)
	{
		return default(bool);
	}

	[Token(Token = "0x601999C")]
	public Vector3 GetGridPos(Vector3 pos)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x601999D")]
	public T GetValueByCoordinate(int row, int column)
	{
		return null;
	}

	[Token(Token = "0x601999E")]
	public Vector3 GetGridCoordinate(Vector3 pos)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x601999F")]
	public Vector3 GetGridCoordinatePos(Vector3 pos)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60199A0")]
	public Vector3 GetGridCoordinatePosByIndex(int index)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60199A1")]
	public Vector3 GetGridPosByCoordinate(Vector3 coordinate)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60199A2")]
	private int GetIndexByXZ(Vector3 pos)
	{
		return default(int);
	}

	[Token(Token = "0x60199A3")]
	public int GetIndexByCoordinate(int row, int column)
	{
		return default(int);
	}

	[Token(Token = "0x60199A4")]
	public Vector3 GetCoordinateByIndex(int index)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60199A5")]
	public void ClearAllValues()
	{
	}

	[Token(Token = "0x60199A6")]
	public void Destroy()
	{
	}
}
