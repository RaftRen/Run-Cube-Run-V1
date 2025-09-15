using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance; //instance - перевод "Экземпляр"
    private void Awake()
    {
        if (instance != null)      //Если скрипт AudiManager(и получается объект Audio) уже есть в сцене, то
        {
            Destroy(gameObject);   //уничтожаем текущий объект, то есть обратившись к gameObject уничотажается
        }                          //объект, компонетном которого является текущий скрипт, то есть объект Audio.
        else
        {                          //Иначе, если в сцене нет Audio, то статической переменной instance мы                  
            instance = this;       //присваиваем ссылку на объект Audio
            DontDestroyOnLoad(gameObject); //и вызываем метод DonDestroyOnLoad, чтобы объект не был уничтожен
        }                                  //после завершения текущей сцены и переходе к следующей
    }
}
