using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParciaisCartola.Models
{
    public class Rootobject
    {
        public Atleta[] atletas { get; set; }
        public Clubes clubes { get; set; }
        public Posicoes posicoes { get; set; }
        public Status status { get; set; }
        public Time time { get; set; }
        public int patrimonio { get; set; }
        public int esquema_id { get; set; }
        public float pontos { get; set; }
        public int valor_time { get; set; }
        public int rodada_atual { get; set; }
    }

    public class Clubes
    {
        public _262 _262 { get; set; }
        public _263 _263 { get; set; }
        public _264 _264 { get; set; }
        public _265 _265 { get; set; }
        public _266 _266 { get; set; }
        public _267 _267 { get; set; }
        public _275 _275 { get; set; }
        public _276 _276 { get; set; }
        public _277 _277 { get; set; }
        public _282 _282 { get; set; }
        public _283 _283 { get; set; }
        public _284 _284 { get; set; }
        public _287 _287 { get; set; }
        public _292 _292 { get; set; }
        public _293 _293 { get; set; }
        public _294 _294 { get; set; }
        public _303 _303 { get; set; }
        public _314 _314 { get; set; }
        public _315 _315 { get; set; }
        public _373 _373 { get; set; }
    }

    public class _262
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
        public int posicao { get; set; }
        public Escudos escudos { get; set; }
    }

    public class Escudos
    {
        public string _60x60 { get; set; }
        public string _45x45 { get; set; }
        public string _30x30 { get; set; }
    }

    public class _263
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
        public int posicao { get; set; }
        public Escudos1 escudos { get; set; }
    }

    public class Escudos1
    {
        public string _60x60 { get; set; }
        public string _45x45 { get; set; }
        public string _30x30 { get; set; }
    }

    public class _264
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
        public int posicao { get; set; }
        public Escudos2 escudos { get; set; }
    }

    public class Escudos2
    {
        public string _60x60 { get; set; }
        public string _45x45 { get; set; }
        public string _30x30 { get; set; }
    }

    public class _265
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
        public int posicao { get; set; }
        public Escudos3 escudos { get; set; }
    }

    public class Escudos3
    {
        public string _60x60 { get; set; }
        public string _45x45 { get; set; }
        public string _30x30 { get; set; }
    }

    public class _266
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
        public int posicao { get; set; }
        public Escudos4 escudos { get; set; }
    }

    public class Escudos4
    {
        public string _60x60 { get; set; }
        public string _45x45 { get; set; }
        public string _30x30 { get; set; }
    }

    public class _267
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
        public int posicao { get; set; }
        public Escudos5 escudos { get; set; }
    }

    public class Escudos5
    {
        public string _60x60 { get; set; }
        public string _45x45 { get; set; }
        public string _30x30 { get; set; }
    }

    public class _275
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
        public int posicao { get; set; }
        public Escudos6 escudos { get; set; }
    }

    public class Escudos6
    {
        public string _60x60 { get; set; }
        public string _45x45 { get; set; }
        public string _30x30 { get; set; }
    }

    public class _276
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
        public int posicao { get; set; }
        public Escudos7 escudos { get; set; }
    }

    public class Escudos7
    {
        public string _60x60 { get; set; }
        public string _45x45 { get; set; }
        public string _30x30 { get; set; }
    }

    public class _277
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
        public int posicao { get; set; }
        public Escudos8 escudos { get; set; }
    }

    public class Escudos8
    {
        public string _60x60 { get; set; }
        public string _45x45 { get; set; }
        public string _30x30 { get; set; }
    }

    public class _282
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
        public int posicao { get; set; }
        public Escudos9 escudos { get; set; }
    }

    public class Escudos9
    {
        public string _60x60 { get; set; }
        public string _45x45 { get; set; }
        public string _30x30 { get; set; }
    }

    public class _283
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
        public int posicao { get; set; }
        public Escudos10 escudos { get; set; }
    }

    public class Escudos10
    {
        public string _60x60 { get; set; }
        public string _45x45 { get; set; }
        public string _30x30 { get; set; }
    }

    public class _284
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
        public int posicao { get; set; }
        public Escudos11 escudos { get; set; }
    }

    public class Escudos11
    {
        public string _60x60 { get; set; }
        public string _45x45 { get; set; }
        public string _30x30 { get; set; }
    }

    public class _287
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
        public int posicao { get; set; }
        public Escudos12 escudos { get; set; }
    }

    public class Escudos12
    {
        public string _60x60 { get; set; }
        public string _45x45 { get; set; }
        public string _30x30 { get; set; }
    }

    public class _292
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
        public int posicao { get; set; }
        public Escudos13 escudos { get; set; }
    }

    public class Escudos13
    {
        public string _60x60 { get; set; }
        public string _45x45 { get; set; }
        public string _30x30 { get; set; }
    }

    public class _293
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
        public int posicao { get; set; }
        public Escudos14 escudos { get; set; }
    }

    public class Escudos14
    {
        public string _60x60 { get; set; }
        public string _45x45 { get; set; }
        public string _30x30 { get; set; }
    }

    public class _294
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
        public int posicao { get; set; }
        public Escudos15 escudos { get; set; }
    }

    public class Escudos15
    {
        public string _60x60 { get; set; }
        public string _45x45 { get; set; }
        public string _30x30 { get; set; }
    }

    public class _303
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
        public int posicao { get; set; }
        public Escudos16 escudos { get; set; }
    }

    public class Escudos16
    {
        public string _60x60 { get; set; }
        public string _45x45 { get; set; }
        public string _30x30 { get; set; }
    }

    public class _314
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
        public int posicao { get; set; }
        public Escudos17 escudos { get; set; }
    }

    public class Escudos17
    {
        public string _60x60 { get; set; }
        public string _45x45 { get; set; }
        public string _30x30 { get; set; }
    }

    public class _315
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
        public int posicao { get; set; }
        public Escudos18 escudos { get; set; }
    }

    public class Escudos18
    {
        public string _60x60 { get; set; }
        public string _45x45 { get; set; }
        public string _30x30 { get; set; }
    }

    public class _373
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
        public int posicao { get; set; }
        public Escudos19 escudos { get; set; }
    }

    public class Escudos19
    {
        public string _60x60 { get; set; }
        public string _45x45 { get; set; }
        public string _30x30 { get; set; }
    }

    public class Posicoes
    {
        public _1 _1 { get; set; }
        public _2 _2 { get; set; }
        public _3 _3 { get; set; }
        public _4 _4 { get; set; }
        public _5 _5 { get; set; }
        public _6 _6 { get; set; }
    }

    public class _1
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
    }

    public class _2
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
    }

    public class _3
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
    }

    public class _4
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
    }

    public class _5
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
    }

    public class _6
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
    }

    public class Status
    {
        public _21 _2 { get; set; }
        public _31 _3 { get; set; }
        public _51 _5 { get; set; }
        public _61 _6 { get; set; }
        public _7 _7 { get; set; }
    }

    public class _21
    {
        public int id { get; set; }
        public string nome { get; set; }
    }

    public class _31
    {
        public int id { get; set; }
        public string nome { get; set; }
    }

    public class _51
    {
        public int id { get; set; }
        public string nome { get; set; }
    }

    public class _61
    {
        public int id { get; set; }
        public string nome { get; set; }
    }

    public class _7
    {
        public int id { get; set; }
        public string nome { get; set; }
    }

    public class Time
    {
        public int time_id { get; set; }
        public int clube_id { get; set; }
        public int esquema_id { get; set; }
        public int cadun_id { get; set; }
        public long facebook_id { get; set; }
        public string foto_perfil { get; set; }
        public string nome { get; set; }
        public string nome_cartola { get; set; }
        public string slug { get; set; }
        public int tipo_escudo { get; set; }
        public string cor_fundo_escudo { get; set; }
        public string cor_borda_escudo { get; set; }
        public string cor_primaria_estampa_escudo { get; set; }
        public string cor_secundaria_estampa_escudo { get; set; }
        public string url_escudo_svg { get; set; }
        public string url_escudo_png { get; set; }
        public string url_camisa_svg { get; set; }
        public string url_camisa_png { get; set; }
        public string url_escudo_placeholder_png { get; set; }
        public string url_camisa_placeholder_png { get; set; }
        public int tipo_estampa_escudo { get; set; }
        public int tipo_adorno { get; set; }
        public int tipo_camisa { get; set; }
        public int tipo_estampa_camisa { get; set; }
        public string cor_camisa { get; set; }
        public string cor_primaria_estampa_camisa { get; set; }
        public string cor_secundaria_estampa_camisa { get; set; }
        public int rodada_time_id { get; set; }
        public bool assinante { get; set; }
        public bool cadastro_completo { get; set; }
        public int patrocinador1_id { get; set; }
        public int patrocinador2_id { get; set; }
        public int temporada_inicial { get; set; }
        public bool simplificado { get; set; }
    }

    public class Atleta
    {
        public string nome { get; set; }
        public string apelido { get; set; }
        public string foto { get; set; }
        public int atleta_id { get; set; }
        public int rodada_id { get; set; }
        public int clube_id { get; set; }
        public int posicao_id { get; set; }
        public int status_id { get; set; }
        public float pontos_num { get; set; }
        public float preco_num { get; set; }
        public float variacao_num { get; set; }
        public float media_num { get; set; }
        public int jogos_num { get; set; }
        public Scout scout { get; set; }
    }

    public class Scout
    {
        public int CA { get; set; }
        public int FS { get; set; }
        public int PE { get; set; }
        public int RB { get; set; }
        public int SG { get; set; }
        public int G { get; set; }
        public int FC { get; set; }
        public int FD { get; set; }
        public int FF { get; set; }
        public int GS { get; set; }
        public int I { get; set; }
    }
}