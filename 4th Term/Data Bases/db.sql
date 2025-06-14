PGDMP  9    %                }            db_test    17.5    17.5 ?               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false            	           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false            
           1262    16390    db_test    DATABASE     {   CREATE DATABASE db_test WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE db_test;
                     postgres    false                        2615    16391    prod    SCHEMA        CREATE SCHEMA prod;
    DROP SCHEMA prod;
                     postgres    false            �            1259    16392    customer    TABLE     �   CREATE TABLE prod.customer (
    buyer_code integer NOT NULL,
    fullname character varying(50) NOT NULL,
    email character varying(30) NOT NULL,
    source character varying(30) NOT NULL
);
    DROP TABLE prod.customer;
       prod         heap r       postgres    false    6            �            1259    16402    products    TABLE     �   CREATE TABLE prod.products (
    prod_code integer NOT NULL,
    prod_name character varying(50) NOT NULL,
    prod_type_code integer NOT NULL
);
    DROP TABLE prod.products;
       prod         heap r       postgres    false    6            �            1259    16408    sale    TABLE     �   CREATE TABLE prod.sale (
    sale_id integer NOT NULL,
    id integer NOT NULL,
    price numeric(10,2) NOT NULL,
    count integer NOT NULL,
    date_of_sale date NOT NULL,
    sale_prod_code integer NOT NULL,
    sale_buyer_code integer NOT NULL
);
    DROP TABLE prod.sale;
       prod         heap r       postgres    false    6                       0    0    COLUMN sale.sale_id    COMMENT     T   COMMENT ON COLUMN prod.sale.sale_id IS 'Èäåíòèôèêàòîð ïðîäàæè';
          prod               postgres    false    222            �            1259    16407    sale_sale_id_seq    SEQUENCE     w   CREATE SEQUENCE prod.sale_sale_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE prod.sale_sale_id_seq;
       prod               postgres    false    6    222                       0    0    sale_sale_id_seq    SEQUENCE OWNED BY     A   ALTER SEQUENCE prod.sale_sale_id_seq OWNED BY prod.sale.sale_id;
          prod               postgres    false    221            �            1259    16397    type    TABLE     i   CREATE TABLE prod.type (
    type_code integer NOT NULL,
    type_name character varying(50) NOT NULL
);
    DROP TABLE prod.type;
       prod         heap r       postgres    false    6            �            1259    16489    book    TABLE     �   CREATE TABLE public.book (
    book_id integer NOT NULL,
    ndoc integer NOT NULL,
    dat date NOT NULL,
    pokup_kod integer NOT NULL
);
    DROP TABLE public.book;
       public         heap r       postgres    false            �            1259    16488    book_book_id_seq    SEQUENCE     y   CREATE SEQUENCE public.book_book_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.book_book_id_seq;
       public               postgres    false    228                       0    0    book_book_id_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.book_book_id_seq OWNED BY public.book.book_id;
          public               postgres    false    227            �            1259    16525    kart    TABLE     �   CREATE TABLE public.kart (
    kart_id integer NOT NULL,
    kol numeric(10,2) NOT NULL,
    cena numeric(12,2) NOT NULL,
    prod_kod integer NOT NULL,
    book_id integer NOT NULL
);
    DROP TABLE public.kart;
       public         heap r       postgres    false            �            1259    16524    kart_kart_id_seq    SEQUENCE     y   CREATE SEQUENCE public.kart_kart_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.kart_kart_id_seq;
       public               postgres    false    230                       0    0    kart_kart_id_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.kart_kart_id_seq OWNED BY public.kart.kart_id;
          public               postgres    false    229            �            1259    16475    spokup    TABLE     �   CREATE TABLE public.spokup (
    pokup_kod integer NOT NULL,
    pokup_name character varying(50) NOT NULL,
    city character varying(40) NOT NULL,
    phone character varying(30) NOT NULL
);
    DROP TABLE public.spokup;
       public         heap r       postgres    false            �            1259    16474    spokup_pokup_kod_seq    SEQUENCE     }   CREATE SEQUENCE public.spokup_pokup_kod_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.spokup_pokup_kod_seq;
       public               postgres    false    224                       0    0    spokup_pokup_kod_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.spokup_pokup_kod_seq OWNED BY public.spokup.pokup_kod;
          public               postgres    false    223            �            1259    16482    sprod    TABLE     �   CREATE TABLE public.sprod (
    prod_kod integer NOT NULL,
    prod_name character varying(50) NOT NULL,
    cena numeric(10,2) NOT NULL,
    vid character varying(30) NOT NULL
);
    DROP TABLE public.sprod;
       public         heap r       postgres    false            �            1259    16481    sprod_prod_kod_seq    SEQUENCE     {   CREATE SEQUENCE public.sprod_prod_kod_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.sprod_prod_kod_seq;
       public               postgres    false    226                       0    0    sprod_prod_kod_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.sprod_prod_kod_seq OWNED BY public.sprod.prod_kod;
          public               postgres    false    225            �            1259    16542 	   vacancies    TABLE     �   CREATE TABLE public.vacancies (
    vac_id bigint NOT NULL,
    country character varying(20) NOT NULL,
    city character varying(20) NOT NULL,
    level character varying(20) NOT NULL,
    vacancy integer NOT NULL
);
    DROP TABLE public.vacancies;
       public         heap r       postgres    false            �            1259    16541    vacancies_vac_id_seq    SEQUENCE     }   CREATE SEQUENCE public.vacancies_vac_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.vacancies_vac_id_seq;
       public               postgres    false    232                       0    0    vacancies_vac_id_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.vacancies_vac_id_seq OWNED BY public.vacancies.vac_id;
          public               postgres    false    231            G           2604    16411    sale sale_id    DEFAULT     h   ALTER TABLE ONLY prod.sale ALTER COLUMN sale_id SET DEFAULT nextval('prod.sale_sale_id_seq'::regclass);
 9   ALTER TABLE prod.sale ALTER COLUMN sale_id DROP DEFAULT;
       prod               postgres    false    222    221    222            J           2604    16492    book book_id    DEFAULT     l   ALTER TABLE ONLY public.book ALTER COLUMN book_id SET DEFAULT nextval('public.book_book_id_seq'::regclass);
 ;   ALTER TABLE public.book ALTER COLUMN book_id DROP DEFAULT;
       public               postgres    false    227    228    228            K           2604    16528    kart kart_id    DEFAULT     l   ALTER TABLE ONLY public.kart ALTER COLUMN kart_id SET DEFAULT nextval('public.kart_kart_id_seq'::regclass);
 ;   ALTER TABLE public.kart ALTER COLUMN kart_id DROP DEFAULT;
       public               postgres    false    229    230    230            H           2604    16478    spokup pokup_kod    DEFAULT     t   ALTER TABLE ONLY public.spokup ALTER COLUMN pokup_kod SET DEFAULT nextval('public.spokup_pokup_kod_seq'::regclass);
 ?   ALTER TABLE public.spokup ALTER COLUMN pokup_kod DROP DEFAULT;
       public               postgres    false    223    224    224            I           2604    16485    sprod prod_kod    DEFAULT     p   ALTER TABLE ONLY public.sprod ALTER COLUMN prod_kod SET DEFAULT nextval('public.sprod_prod_kod_seq'::regclass);
 =   ALTER TABLE public.sprod ALTER COLUMN prod_kod DROP DEFAULT;
       public               postgres    false    226    225    226            L           2604    16545    vacancies vac_id    DEFAULT     t   ALTER TABLE ONLY public.vacancies ALTER COLUMN vac_id SET DEFAULT nextval('public.vacancies_vac_id_seq'::regclass);
 ?   ALTER TABLE public.vacancies ALTER COLUMN vac_id DROP DEFAULT;
       public               postgres    false    231    232    232            �          0    16392    customer 
   TABLE DATA           E   COPY prod.customer (buyer_code, fullname, email, source) FROM stdin;
    prod               postgres    false    218   �E       �          0    16402    products 
   TABLE DATA           F   COPY prod.products (prod_code, prod_name, prod_type_code) FROM stdin;
    prod               postgres    false    220   G       �          0    16408    sale 
   TABLE DATA           f   COPY prod.sale (sale_id, id, price, count, date_of_sale, sale_prod_code, sale_buyer_code) FROM stdin;
    prod               postgres    false    222   xG       �          0    16397    type 
   TABLE DATA           2   COPY prod.type (type_code, type_name) FROM stdin;
    prod               postgres    false    219   �G                  0    16489    book 
   TABLE DATA           =   COPY public.book (book_id, ndoc, dat, pokup_kod) FROM stdin;
    public               postgres    false    228   7H                 0    16525    kart 
   TABLE DATA           E   COPY public.kart (kart_id, kol, cena, prod_kod, book_id) FROM stdin;
    public               postgres    false    230   �H       �          0    16475    spokup 
   TABLE DATA           D   COPY public.spokup (pokup_kod, pokup_name, city, phone) FROM stdin;
    public               postgres    false    224   �H       �          0    16482    sprod 
   TABLE DATA           ?   COPY public.sprod (prod_kod, prod_name, cena, vid) FROM stdin;
    public               postgres    false    226   �I                 0    16542 	   vacancies 
   TABLE DATA           J   COPY public.vacancies (vac_id, country, city, level, vacancy) FROM stdin;
    public               postgres    false    232   �J                  0    0    sale_sale_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('prod.sale_sale_id_seq', 1, false);
          prod               postgres    false    221                       0    0    book_book_id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.book_book_id_seq', 1, false);
          public               postgres    false    227                       0    0    kart_kart_id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.kart_kart_id_seq', 1, false);
          public               postgres    false    229                       0    0    spokup_pokup_kod_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.spokup_pokup_kod_seq', 1, false);
          public               postgres    false    223                       0    0    sprod_prod_kod_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.sprod_prod_kod_seq', 1, false);
          public               postgres    false    225                       0    0    vacancies_vac_id_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.vacancies_vac_id_seq', 17, true);
          public               postgres    false    231            N           2606    16396    customer customer_pk 
   CONSTRAINT     X   ALTER TABLE ONLY prod.customer
    ADD CONSTRAINT customer_pk PRIMARY KEY (buyer_code);
 <   ALTER TABLE ONLY prod.customer DROP CONSTRAINT customer_pk;
       prod                 postgres    false    218            R           2606    16406    products products_pk 
   CONSTRAINT     W   ALTER TABLE ONLY prod.products
    ADD CONSTRAINT products_pk PRIMARY KEY (prod_code);
 <   ALTER TABLE ONLY prod.products DROP CONSTRAINT products_pk;
       prod                 postgres    false    220            T           2606    16413    sale sale_pk 
   CONSTRAINT     M   ALTER TABLE ONLY prod.sale
    ADD CONSTRAINT sale_pk PRIMARY KEY (sale_id);
 4   ALTER TABLE ONLY prod.sale DROP CONSTRAINT sale_pk;
       prod                 postgres    false    222            P           2606    16401    type type_pk 
   CONSTRAINT     O   ALTER TABLE ONLY prod.type
    ADD CONSTRAINT type_pk PRIMARY KEY (type_code);
 4   ALTER TABLE ONLY prod.type DROP CONSTRAINT type_pk;
       prod                 postgres    false    219            Z           2606    16494    book book_pk 
   CONSTRAINT     O   ALTER TABLE ONLY public.book
    ADD CONSTRAINT book_pk PRIMARY KEY (book_id);
 6   ALTER TABLE ONLY public.book DROP CONSTRAINT book_pk;
       public                 postgres    false    228            \           2606    16530    kart kart_pk 
   CONSTRAINT     O   ALTER TABLE ONLY public.kart
    ADD CONSTRAINT kart_pk PRIMARY KEY (kart_id);
 6   ALTER TABLE ONLY public.kart DROP CONSTRAINT kart_pk;
       public                 postgres    false    230            V           2606    16480    spokup spokup_pk 
   CONSTRAINT     U   ALTER TABLE ONLY public.spokup
    ADD CONSTRAINT spokup_pk PRIMARY KEY (pokup_kod);
 :   ALTER TABLE ONLY public.spokup DROP CONSTRAINT spokup_pk;
       public                 postgres    false    224            X           2606    16487    sprod sprod_pk 
   CONSTRAINT     R   ALTER TABLE ONLY public.sprod
    ADD CONSTRAINT sprod_pk PRIMARY KEY (prod_kod);
 8   ALTER TABLE ONLY public.sprod DROP CONSTRAINT sprod_pk;
       public                 postgres    false    226            ^           2606    16547    vacancies vacancies_pk 
   CONSTRAINT     X   ALTER TABLE ONLY public.vacancies
    ADD CONSTRAINT vacancies_pk PRIMARY KEY (vac_id);
 @   ALTER TABLE ONLY public.vacancies DROP CONSTRAINT vacancies_pk;
       public                 postgres    false    232            `           2606    16414    sale customer_sale_fk    FK CONSTRAINT     �   ALTER TABLE ONLY prod.sale
    ADD CONSTRAINT customer_sale_fk FOREIGN KEY (sale_buyer_code) REFERENCES prod.customer(buyer_code) ON UPDATE RESTRICT ON DELETE RESTRICT;
 =   ALTER TABLE ONLY prod.sale DROP CONSTRAINT customer_sale_fk;
       prod               postgres    false    218    222    4686            a           2606    16424    sale products_sale_fk    FK CONSTRAINT     �   ALTER TABLE ONLY prod.sale
    ADD CONSTRAINT products_sale_fk FOREIGN KEY (sale_prod_code) REFERENCES prod.products(prod_code) ON UPDATE RESTRICT ON DELETE RESTRICT;
 =   ALTER TABLE ONLY prod.sale DROP CONSTRAINT products_sale_fk;
       prod               postgres    false    222    220    4690            _           2606    16419    products type_products_fk    FK CONSTRAINT     �   ALTER TABLE ONLY prod.products
    ADD CONSTRAINT type_products_fk FOREIGN KEY (prod_type_code) REFERENCES prod.type(type_code) ON UPDATE RESTRICT ON DELETE RESTRICT;
 A   ALTER TABLE ONLY prod.products DROP CONSTRAINT type_products_fk;
       prod               postgres    false    4688    219    220            c           2606    16536    kart book_kart_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.kart
    ADD CONSTRAINT book_kart_fk FOREIGN KEY (book_id) REFERENCES public.book(book_id) ON UPDATE RESTRICT ON DELETE RESTRICT;
 ;   ALTER TABLE ONLY public.kart DROP CONSTRAINT book_kart_fk;
       public               postgres    false    230    4698    228            b           2606    16502    book spokup_book_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.book
    ADD CONSTRAINT spokup_book_fk FOREIGN KEY (pokup_kod) REFERENCES public.spokup(pokup_kod) ON UPDATE RESTRICT ON DELETE RESTRICT;
 =   ALTER TABLE ONLY public.book DROP CONSTRAINT spokup_book_fk;
       public               postgres    false    228    4694    224            d           2606    16531    kart sprod_kart_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.kart
    ADD CONSTRAINT sprod_kart_fk FOREIGN KEY (prod_kod) REFERENCES public.sprod(prod_kod) ON UPDATE RESTRICT ON DELETE RESTRICT;
 <   ALTER TABLE ONLY public.kart DROP CONSTRAINT sprod_kart_fk;
       public               postgres    false    4696    226    230            �     x�u��N1���S�H¯��AH&�	���@\!.X�btb���=~�|��7�Lg 7�I���woO��Ŵ��ў} $�B�1�~�!lP��̈́�TG<�O{�V���hF!%�!L��y�Y�y�mƟ�&KB��T��1�����ʶ.����D���5/3�"�)3�9;��-���y9BoT_�1��]�����L��2�|0a���G�jq����\��{�z�<���1Qn���d�>m��跆��
_�E�q"��'K�y��9����      �   T   x�3�0�¾��xׅ}��\F�^�� d��^l�n�4�2ἰ��V g�����\��\�pa˅@��\1z\\\ �)�      �   V   x�-���0D���K,��NzI�u�H�O�U�*����@�h��1gC���<荫��%��<�ƻ�?��'�Ak|��Ay��|�9      �   I   x�3�0�bÅ}� �& �}��b��& {ǅ�\F�&^���e�ya���^�u�	�~/P~ׅ\1z\\\ 2�*|          F   x�E̱�0���E�HI�&����/(�"��/B�`����Qyd���ͅ���+����         `   x�]���0C��az������b���?xI ������A�7�<I�|�4Q�M�:ns�ٱ/��j��q�䀞�造��J.u���<�F�      �   �   x�m�An�0EמSxY��6�.=L�lYP�EUU,zD����}#�*�"K�ǚ7��j�-��;�������17�qȯ�8������),���]��R��2b���]���̪N�.%�n�6�9� ��8��K�W�5ØT'�*�n�;"���a�H| �;Z\C���DOu�K�C��r�(M��"U��������mI�l�
��"�Q^�E����      �   �   x�U�M
�0�דS��6m
���hܸp���Hk�3����AH�üo�MC������aB�H�j[��*S��4O��
8$�pd�����pC��A���T���!J�<P�ԅ]�ى�����p�>X��x2��IU}���]m�R����[         �   x���]N�0���we���w�0ixEB�B�p��J	W߈q�*�v��X�2���X��ʭ0�G�g��v�~]�{��|�ZSdbꕂ\{�����������ll)y`����[��(UKPo�}�����5}����b�M�IuՂ���������ԩxT�V��q��V�W�4�R�O U�5z�]C㳨�T�����O�zFM,E����?�"l-Z����-�G���]�����	�B�nE���_�     