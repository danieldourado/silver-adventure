using NinevaStudios.GoogleMaps;
using UnityEngine;

public class GoogleMapsMinimalDemo : MonoBehaviour
{
	GoogleMapsView _map;
	public RectTransform rect;

	void Start()
	{
		var cameraPosition = new CameraPosition(
			new LatLng(-15.7964211f, -47.8898464f), 11, 0, 0);
		var options = new GoogleMapsOptions()
			.Camera(cameraPosition);

		_map = new GoogleMapsView(options);
        _map.Show(RectTransformToScreenSpace(rect), OnMapReady);
    }

	void OnMapReady()
	{
		_map.AddMarker(new MarkerOptions().Position(new LatLng(-15.804948f, -47.949997f)).Title("SICOOB").Snippet("QUADRA SIA QUADRA 4-C, 36, LOJA 36 TÉRREO, Zona Industrial (Guará), Brasília - 71200-045"));
		_map.AddMarker(new MarkerOptions().Position(new LatLng(-15.798548f, -47.880858f)).Title("SICOOB COOPERPLAN").Snippet("SBS QD 01 BL J ED BNDES/IPEA SL.108, 1, SOBRELOJA, ASA SUL, Brasília - 70076-900"));
		_map.AddMarker(new MarkerOptions().Position(new LatLng(-15.7964211f, -47.8898464f)).Title("SICOOB CREDFAZ").Snippet("QD SCS QUADRA 5 BLOCO C LOTES 165 E 169, 165, Asa Sul, Brasília - 70305-921"));
		_map.AddMarker(new MarkerOptions().Position(new LatLng(-15.739804f, -47.893267f)).Title("SICOOB CREDIEMBRAPA").Snippet("CLN 116 Bl H, , LOJAS 59 E 65, Asa Norte, Brasília - 70773-580"));
		_map.AddMarker(new MarkerOptions().Position(new LatLng(-15.797050f, -47.886547f)).Title("SICOOB CREDIJUSTRA").Snippet("QD SCS QUADRA 2 BLOCO D, 3, SL 402 A 405 ED.OSCA, ASA SUL, Brasília - 70316-900"));
		_map.AddMarker(new MarkerOptions().Position(new LatLng(-15.7823f, -47.8873f)).Title("SICOOB CREDSEF").Snippet("SRTVN QUADRA 702 CONJ P SOBRELOJA, 50, ED. RADIO CENTER, ASA NORTE, BRASÍLIA - 70719-900"));
		_map.AddMarker(new MarkerOptions().Position(new LatLng(-15.802900f, -47.963502f)).Title("SICOOB EMPRESARIAL").Snippet("TRC SIA Trecho 3, 225, TÉRREO ED FIBRA, Zona Industrial (Guará), Brasília - 71200-030"));
		_map.AddMarker(new MarkerOptions().Position(new LatLng(-15.787927f, -47.878745f)).Title("SICOOB EXECUTIVO").Snippet("SBN QD 2 BL J ED ENGENHEIRO, , LOJAS 2,3,4 E MEZANI, ASA NORTE, Brasília - 70040-905"));
		_map.AddMarker(new MarkerOptions().Position(new LatLng(-15.80854f, -47.86614f)).Title("SICOOB JUDICIÁRIO").Snippet("ESPLANADA SAF SUL QD-06 LOTE 01 SALA 07, S/N, ED PLENÁRIOS - STJ, ASA SUL, Brasília - 70070-600"));
		_map.AddMarker(new MarkerOptions().Position(new LatLng(-15.8025f, -47.8629f)).Title("SICOOB LEGISLATIVO").Snippet("SAF SUL QUADRA 04 LOTE 1 2º SUBSOLO, S/N, ED. ANEXO III TCU, ASA SUL, Brasília - 70042-900"));
        _map.IsVisible = false;
	}

    public void Show()
    {
        _map.IsVisible = true;
        Screen.orientation = ScreenOrientation.Portrait;
    }

    public void Hide()
    {
        _map.IsVisible = false;
        Screen.orientation = ScreenOrientation.AutoRotation;
    }
	static Rect RectTransformToScreenSpace(RectTransform transform)
	{
		Vector2 size = Vector2.Scale(transform.rect.size, transform.lossyScale);
		Rect rect = new Rect(transform.position.x, Screen.height - transform.position.y, size.x, size.y);
		rect.x -= transform.pivot.x * size.x;
		rect.y -= (1.0f - transform.pivot.y) * size.y;
		rect.x = Mathf.CeilToInt(rect.x);
		rect.y = Mathf.CeilToInt(rect.y);
		return rect;
	}
}