-- Table: public.admin

-- DROP TABLE IF EXISTS public.admin;

CREATE TABLE IF NOT EXISTS public.admin
(
    adminid integer NOT NULL,
    ad character varying(20) COLLATE pg_catalog."default" NOT NULL,
    soyad character varying(20) COLLATE pg_catalog."default" NOT NULL,
    sifre character varying(20) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT admin_pkey PRIMARY KEY (adminid)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.admin
    OWNER to postgres;
    
-- Table: public.araclar

-- DROP TABLE IF EXISTS public.araclar;

CREATE TABLE IF NOT EXISTS public.araclar
(
    aracid integer NOT NULL,
    marka character varying(15) COLLATE pg_catalog."default" NOT NULL,
    model character varying(15) COLLATE pg_catalog."default" NOT NULL,
    sanzuman character varying(8) COLLATE pg_catalog."default" NOT NULL,
    ortyakit double precision NOT NULL,
    gunlukucret double precision NOT NULL,
    aracyasi integer NOT NULL,
    CONSTRAINT araclar_pkey PRIMARY KEY (aracid)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.araclar
    OWNER to postgres;

-- Table: public.mudur

-- DROP TABLE IF EXISTS public.mudur;

CREATE TABLE IF NOT EXISTS public.mudur
(
    -- Inherited from table public.admin: adminid integer NOT NULL,
    -- Inherited from table public.admin: ad character varying(20) COLLATE pg_catalog."default" NOT NULL,
    -- Inherited from table public.admin: soyad character varying(20) COLLATE pg_catalog."default" NOT NULL,
    -- Inherited from table public.admin: sifre character varying(20) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT mudur_pkey PRIMARY KEY (adminid)
)
    INHERITS (public.admin)
TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.mudur
    OWNER to postgres;


-- Table: public.uyeler

-- DROP TABLE IF EXISTS public.uyeler;

CREATE TABLE IF NOT EXISTS public.uyeler
(
    -- Inherited from table public.mudur: adminid integer NOT NULL,
    -- Inherited from table public.mudur: ad character varying(20) COLLATE pg_catalog."default" NOT NULL,
    -- Inherited from table public.mudur: soyad character varying(20) COLLATE pg_catalog."default" NOT NULL,
    -- Inherited from table public.mudur: sifre character varying(20) COLLATE pg_catalog."default" NOT NULL,
    telefon character varying(10) COLLATE pg_catalog."default" NOT NULL,
    dob character varying(10) COLLATE pg_catalog."default" NOT NULL,
    tc character varying(11) COLLATE pg_catalog."default" NOT NULL
    eposta character varying(30) COLLATE pg_catalog."default" NOT NULL
    cinsiyet char COLLATE pg_catalog."default" NOT NULL
)
    INHERITS (public.mudur)
TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.uyeler
    OWNER to postgres;



INSERT INTO public.admin(
	adminid, ad, soyad, sifre)
	VALUES (1, 'melih', 'aybar', 123);
	


INSERT INTO public.araclar(
	aracid, marka, model, sanzuman, ortyakit, gunlukucret, aracyasi)
	VALUES (1, 'audi', 'a3', 'otomatik', 6, 350, 3);
	
INSERT INTO public.mudur(
	adminid, ad, soyad, sifre)
	VALUES (1, 'Cankat', 'Kalem', 123);


INSERT INTO public.uyeler(
	adminid, ad, soyad, sifre, telefon, dob, tc)
	VALUES (1, 'Ahmet', 'Onlu', 123, '5333333333', '20.11.1996', '12345678901','ahmetonlu@gmail.com','e');
	
